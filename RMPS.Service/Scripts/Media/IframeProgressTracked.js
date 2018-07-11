gotChildInit = false;
didFinish = false;

function receiveMessage(event) {
    if (event.data.messageType === 'request-stop-init')
        gotChildInit = true;

    if (event.data.messageType === 'request-start-set-position')
        sendChildMessage({ messageType: "set-position", position: getStartPosition() });

    if (event.data.messageType === 'set-position')
        logSlide(event.data.position);

    if (event.data.messageType === 'set-dimensions')
        setDimensions(event.data.width, event.data.height)

    if (event.data.messageType === 'set-final-position')
        totalSlides = event.data.position;

    if (event.data.messageType === 'alert')
        alert(event.data.message);

    if (event.data.messageType === 'set-deck-finished')
        logFinished();
}

window.addEventListener("message", receiveMessage, false);

function setDimensions(width, height) {
    console.log(width, height);
    iframe = jQuery("#media");
    console.log(iframe);
    iframe.height(height);
    iframe.width(width);
}

function logSlide(index) {
    logCurrent(index, totalSlides);
}

function logFinished() {
    didFinish = true;
    logCurrent(totalSlides, totalSlides); // Force log at the very end
}

jQuery(document).ready(function () {
    childInitLoop();

    //$("#NextButton").on("click", nextButtonClicked);
});

function childInitLoop() {
    console.log("Init loop");

    // Break the loop
    if (gotChildInit)
        return;

    sendChildMessage({ messageType: "parent-ready" });
    sendChildMessage({ messageType: "set-enable-skip-protection", value: !getIsSkippingaheadEnabled() });
    setTimeout(childInitLoop, 100)
}

function sendChildMessage(params) {
    jQuery("#media")[0].contentWindow.postMessage(params, "*");
}

function nextButtonClicked(event) {
    if (!getIsSkippingaheadEnabled())
        return;

    if (!didFinish) {
        event.preventDefault();
        alert("You must complete the course before moving ahead.");
    }
}