var didJWPlayerSetup = false;

var playerIsOk = false;

function conditionalJwPlayerSetup(jwPlayerParams) {
    if (jwPlayerParams.sources.length === 0 && !jwPlayerParams.sourceUrl)
    {
        return;
    }

    if (jwPlayerParams.sources.length > 0) {
        $.ajax({
            type: "GET",
            url: jwPlayerParams.sources[0].file
        })
            .done(function (data, textStatus, jqXHR) {
                setTimeout(function() { doJwPlayerSetup(jwPlayerParams) }, 1000);
            })
            .fail(function (data, textStatus, jqXHR) {
                setTimeout(function() { refreshMediaPath(jwPlayerParams) }, 5000);
            });
    } else {
        refreshMediaPath(jwPlayerParams);
    }
}

function refreshMediaPath(jwPlayerParams) {
    $.ajax({
        type: "POST",
        url: jwPlayerParams.sourceUrl,
    }).done(function (data, textStatus, jqXHR) {
        if (data.Path) {
            var source;

            if (data.Path.match(".m3u8"))
                source = { file: data.Path, type: 'hls' }
           
            else if (data.Path.match(".f4m"))
                source = { file: data.Path, type: 'mp4' };
            else
                source = { file: data.Path };

            jwPlayerParams.sources = [source];

            conditionalJwPlayerSetup(jwPlayerParams);

        } else {
            console.log("Path not in refresh return");
            setTimeout(function () { refreshMediaPath(jwPlayerParams) }, 5000);
        }
    }).fail(function (data, textStatus, jqXHR) {
        console.log("Refresh media path failure", textStatus, data);
        refreshMediaPath(jwPlayerParams);
    })
}

function shouldRunCookieAuthentication(jwPlayerParams) {
    var sources = jwPlayerParams.sources;
    var shouldRuncookieAuth = false;

    sources.forEach(function (source) {
        if (source.type === "hls" && source.file.match("^https://video\.mrmportal\.com"))
            if (! window.location.hostname.match("\.mrmportal\.com$"))
                shouldRuncookieAuth = true;
    });

    return shouldRuncookieAuth;
}

function startPeriodicCookieAuthentication(authURL, cookieURL, authParameters, jwPlayerParams) {
    // Inject the origin domain
    authParameters.originDomain = getOriginDomain();

    function runCookieAuth() {
        $.ajax({
            type: "POST",
            url: authURL,
            data: authParameters
        }).done(function (data, textStatus, jqXHR) { sendCookieData(cookieURL, data, jwPlayerParams); });

        setTimeout(runCookieAuth, 30000);
    }

    runCookieAuth();
}

function sendCookieData(cookieUrl, encodedCookieData, jwPlayerParams) {

    $.ajax({
        url: cookieUrl,
        data: encodedCookieData,
        xhrFields: { withCredentials: true }
    })
        .done(function (data, textStatus, jqXHR) { finalizeCookieData(data, jwPlayerParams) })
        .error(function (jqXHR, textStatus, errorThrown) {
            console.log("JSON authentication failure, sending image auth");
            sendCookieDataImage(cookieUrl, encodedCookieData, jwPlayerParams);
        });
}

function sendCookieDataImage(cookieUrl, encodedCookieData, jwPlayerParams) {
    encodedCookieData.ReturnType = "image";
    var queryString = $.param(encodedCookieData);
    var imageUrl = cookieUrl + "?" + queryString;

    $("#auth-image img").attr("src", imageUrl);
    $("#auth-image img").load(function () { finalizeCookieData(null, jwPlayerParams); })
}

function finalizeCookieData(cookieData, jwPlayerParams) {
    if (!didJWPlayerSetup)
        doJwPlayerSetup(jwPlayerParams);
}

function showMedia() {
    if (playerIsOk) {
        $("#media-loading").hide();
        $("#media-wrapper").show();
    } else {
        console.log("Player was not OK");
    }
}

function doJwPlayerSetup(params) {
    didJWPlayerSetup = true;

    // Assume the player is OK until it errors out
    playerIsOk = true;

    setTimeout(function () { showMedia(); }, 15000);

    jwplayer('media').setup({
        playlist: [{
            image: params.placeholder,
            sources: params.sources
        }],

        aspectratio: '16:9',
        width: '100%',
        primary: 'html5',
        androidhls: true,
        autostart: true,
        withCredentials: true,

        events: {
            onTime: function (event) {
                if (this.isInitialSeek) {
                    // Only on initial load: jump to the last logged position. When
                    // player is at the OnReady event, seeking will not work, so
                    // the initial seek is done at the OnTime event.
                    this.isInitialSeek = false;
                    this.seek(this.maxLoggedPosition);
                }

                if (!this.isAutomaticSeek) {
                    if (this.isManualForwardSeek) {
                        // Backup to the previous position if the user is not
                        // allowed to seek past where they have already viewed.
                        this.isAutomaticSeek = true;
                        this.isManualForwardSeek = false;
                        this.seek(this.maxLoggedPosition);
                    }
                    else {
                        this.maxLoggedPosition = Math.max(event.position, this.maxLoggedPosition);

                        // If the log interval (15 seconds) has passed or no log
                        // exists, then log the current position if necessary.
                        if (this.maxLoggedPosition > this.lastLoggedPosition + 15 || this.lastLoggedPosition === 0) {
                            this.lastLoggedPosition = this.maxLoggedPosition;
                            if (isLoggingEnabled) {
                                logStatus(this.lastLoggedPosition, this.getDuration(), params.logCurrentURL, true);
                            }
                        }
                    }
                }
            },

            onSeek: function (event) {
                if (!isSkippingAheadEnabled){
                    if (!this.isAutomaticSeek) {
                        if (event.offset > this.maxLoggedPosition) {
                            this.isManualForwardSeek = true;
                            alert('You cannot advance beyond what you have already watched.');
                        }
                    }

                    this.isAutomaticSeek = false;
                }
            },

            onComplete: function () {
                if (isLoggingEnabled) {
                    logStatus(this.getDuration(), this.getDuration(), params.logCurrentURL, true);
                }
            },

            onReady: function () {
                this.lastLoggedPosition = params.startTime;
                this.maxLoggedPosition = params.startTime;
                this.isAutomaticSeek = false;
                this.isManualForwardSeek = false;
                this.isInitialSeek = true;

                if (isLoggingEnabled) {
                    // Setup unload event to log position when the user navigates
                    // away from the page containing the player.
                    var jw = this;
                    window.onbeforeunload = function() {
                        if (!jw.isAutomaticSeek && !jw.isManualForwardSeek) {
                            logStatus(jw.getPosition(), jw.getDuration(), params.logExitURL, false);
                        }
                        else {
                            logStatus(jw.lastLoggedPosition, jw.getDuration(), params.logExitURL, false);
                        }
                    }
                }
            },

            onError: function (e) {
                if (params.sourceUrl)
                {
                    $("#media").html("Loading player...");
                    setTimeout(function () { refreshMediaPath(params) }, 15000);
                    console.log("JWPlayer Error", e);

                    playerIsOk = false;
                }
            },

            onPlay: function () {
                playerIsOk = true;
                showMedia();
            }
        }
    });
}

function logStatus(currentTime, totalTime, url, async) {
    $.ajax({
        async: async,
        type: 'POST',
        url: url,
        data: {
            currentTime: currentTime,
            totalTime: totalTime
        }
    });
}

function getOriginDomain() {
    var originDomain = window.location.protocol + "//" + window.location.hostname;


    if ((window.location.protocol.toLowerCase() === "http:"
         && window.location.port !== "80"
         && window.location.port !== "") ||
        (window.location.protocol.toLowerCase() === "https:"
         && window.location.port !== "443"
         && window.location.port !== "")) {
            originDomain = originDomain + ":" + window.location.port;
    }

    return originDomain;
}