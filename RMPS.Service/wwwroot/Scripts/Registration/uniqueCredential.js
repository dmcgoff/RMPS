var getValidator = function (element) {
    return element.kendoValidator({
        rules: {
            equalto: function (input) {
                if (input.is("[data-val-equalto]")) {
                    var namedField = input.attr("data-val-equalto-other");
                    var comparedField = $("#" + namedField.replace('*.', ''));
                    return input.val() === comparedField.val();
                }

                return true;
            },
            checkboxrequired: function (input) {
                if (input.is("[data-val-checkboxrequired]")) {
                    var namedField = input.attr("name");;
                    var comparedFields = $('input[name=' + namedField + ']:checked');

                    if (input.is("[data-val-checkboxrequired-alternateSelection]")) {
                        var alternative = input.attr("data-val-checkboxrequired-alternateSelection");
                        var alternativeField = $('input[name=' + alternative + ']');
                        return comparedFields.length > 0 || alternativeField.val().length > 0;
                    }
                    return comparedFields.length > 0;
                }

                return true;
            },
            customRequired: function (input) {
                if (input.is("[data-val-required]")) {
                    if (input.val() === "") {
                        return false;
                    }
                }

                return true;
            },
            available: function (input) {
                if (input.is("[data-available]") && input.is("[data-val-required]")) {

                    // cache the field's id
                    var id = input.attr('id');

                    // create a new cache object for this field if one doesn't already exist
                    var cache = availability.cache[id] = availability.cache[id] || {};

                    // set our status to checking
                    cache.checking = true;

                    // if the value in the cache and the current input value are the same
                    // and the cached state is valid...
                    if (cache.value === input.val() && cache.valid) {

                        isUnique[input.attr('name')] = true;

                        // the value is available
                        return true;

                    }

                    // if the value in the cache and the input value are the same 
                    // and the cached state is not valid...
                    if (cache.value === input.val() && !cache.valid) {

                        isUnique[input.attr('name')] = false;

                        // the value is not available
                        cache.checking = false;
                        return false;

                    }

                    // go to the ajax check
                    availability.check(input, input.data('available-url'));

                    // return false which goes into 'checking...' mode
                    return false;

                }

                return true;
            }
        },
        messages: {
            equalto: function (input) {
                return input.attr("data-val-equalto");
            },
            checkboxrequired: function (input) {
                return input.attr("data-val-checkboxrequired");
            },
            customRequired: function (input) {
                return input.attr("data-val-required");
            },
            available: function (input) {

                var id = input.attr('id');
                var cache = availability.cache[id];

                if (cache.checking) {
                    return "Checking...";
                }

                else {
                    if (!input.is("[data-val-required]") && input.text() == "") {
                        return null;
                    } else if (input.val() == "") {
                        return input.attr("data-available-name") + ' is required.';
                    } else {
                        return 'The ' + input.attr("data-available-name") + ' <b>' + input[0].value + '</b> is already in use.';
                    }
                }
            }
        },
        validate: function (e) {
            if (!e.valid) {
                $(".error-header").show();
            } else {
                $(".error-header").hide();
            }
            if (isUnique.EmailAddress && isUnique.SecondaryEmailAddress && isUnique.UserName && isNext) {
                
                isNext = false;

                if (!formComplete && getValidator($(tabs.contentElement(1))).validate()) {
                    switchingonvalidation = true;
                    tabs.enable(getTabAtIndex(2), true);
                    tabs.select(getTabAtIndex(2));
                } else {
                    e.preventDefault();
                }

            }
        }
    }).data("kendoValidator");
}

var availability = {

    cache: {},

    check: function (element, url) {

        var id = element.attr('id');
        var cache = this.cache[id] = this.cache[id] || {};

        $.ajax({
            url: url,
            dataType: 'json',
            data: { credential: element.val() },

            success: function (data) {

                // the `data` object returns true or false
                // based on the availability of the value


                // set the value on the cache object so 
                // that it can be referenced in the next validation run
                cache.valid = data;

            },

            failure: function () {

                // the ajax call failed so just set the field
                // as valid since we don't know for sure that it's not
                cache.valid = true;
            },

            complete: function () {

                // trigger validation again
                //getValidator.validateInput(element);
                getValidator($(element)).validate();

                // cache the element's value
                cache.value = element.val();
            }
        });
    }
};

