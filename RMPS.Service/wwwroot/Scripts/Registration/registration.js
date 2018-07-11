var tabs,
    currentIndex = 0;

var formComplete = false;

var isUnique = { EmailAddress: false, SecondaryEmailAddress: false, UserName: false };
var isNext = false;

var switchingonvalidation = false;

$(document).ready(function () {

    tabs = $("#tabstrip").kendoTabStrip({
        select: onSelect
    }).data("kendoTabStrip");
    

    $("#submitform").on("click",
        function (e) {
            e.preventDefault();
            $("form").submit();
        });

    $("form").submit(function (e) {
        e.preventDefault();

        if (!getValidator($("form")).validate()) {
            return false;
        } else {
            var formData = $("form").serialize();
            kendo.ui.progress($(document.body), true);
            $.post('/Security/Account/Register',
                formData,
                function (response) {
                    kendo.ui.progress($(document.body), false);
                    if (response.status === 201) {
                        tabs.select(getTabAtIndex(currentIndex + 1));
                        formComplete = true;
                    } else {
                        console.log(response);
                    }
                });
        }
    });

    $("#ValidateRegCode").on("click",
        function () {
            if ($("#RegistrationCode").val()) {
                window.location.href = '/Security/Account/RegistrationCode?' +
                    $.param({ 'registrationCode': $("#RegistrationCode").val() });
            }
        }
    );


    $(".previous-step").on("click",
        function (e) {
            onPreviousClick(e);
        }
    );

    if ($("#UserId").val()) {
        tabs.select(getTabAtIndex(currentIndex + 1));
        $(".field-validation-error").hide();
    } else {
        tabs.select(getTabAtIndex(currentIndex));
    }

    if ($("#AdditionalCredentials").val() == "") {
        $("#AdditionalCredentials").attr('disabled', 'disabled');
    }

    $("#additionalcredentialscheckbox").on("click",
        function () {
            if ($("#AdditionalCredentials").attr('disabled'))
                $("#AdditionalCredentials").removeAttr('disabled');
            else $("#AdditionalCredentials").attr('disabled', 'disabled');
        }
    );
});

function onSelect(e) {

    var selectedIndex = tabIndexOfElement(e.item),
        isMovingBack = selectedIndex < currentIndex;
    if (!formComplete && (isMovingBack || switchingonvalidation || isTabValidAt(currentIndex))) {
        switchingonvalidation = false;
        currentIndex = selectedIndex;
        tabs.enable(getTabAtIndex(currentIndex), true);
    } else {
        e.preventDefault();
    }
}

function onPreviousClick(e) {
    e.preventDefault();
    tabs.select(tabs.select().prev());
}

function onNextClick(e) {
    isNext = true;
    tabs.select(getTabAtIndex(currentIndex + 1));
}

function getTabAtIndex(index) {
    return tabs.tabGroup.children().eq(index);
}

function tabIndexOfElement(element) {
    return tabs.element.find(element).index();
}

function isTabValidAt(tabIndex) {
    var el = tabs.contentElement(tabIndex);
    return getValidator($(el)).validate();
}


function clientId() {
    return {
        clientId: $("#ClientId").val()
    };
}

