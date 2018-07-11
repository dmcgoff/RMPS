// Alert and Confirm Modals
$(function () {
    $('.modal').on('show.bs.modal', function () {
        $('body').addClass('modal-body-fix');
    });

    $('.modal').on('shown.bs.modal', function () {
        $("body.modal-open").removeAttr("style");
    });

    $('.modal').on('hidden.bs.modal', function () {
        $('body').removeClass('modal-body-fix');
    });
});

function alert(options) {
    var type = 'primary';
    var icon = '';
    var title = 'Alert';
    var body = '';

    var modal = $('#modal-alert');

    if (typeof options == 'object') {
        type = options['type'];
        icon = options['icon'];
        title = options['title'];
        body = options['body'];
    }
    else {
        body = options + '';
    }

    modal.find('#modal-alert-type').removeClass();
    modal.find('#modal-alert-type').addClass('modal-' + type);

    modal.find('#modal-alert-icon').removeClass();
    modal.find('#modal-alert-icon').addClass(icon);

    modal.find('.modal-alert-title').text(title);

    modal.find('.modal-alert-body').text(body);

    $('#modal-alert').modal('show');
};

function confirm(options, callback) {
    var type = 'primary';
    var icon = '';
    var title = 'Confirm';
    var body = '';

    var modal = $('#modal-confirm');

    if (typeof options == 'object') {
        type = options['type'];
        icon = options['icon'];
        title = options['title'];
        body = options['body'];
    }
    else {
        body = options + '';
    }

    modal.find('#modal-confirm-type').removeClass();
    modal.find('#modal-confirm-type').addClass('modal-' + type);

    modal.find('#modal-confirm-icon').removeClass();
    modal.find('#modal-confirm-icon').addClass(icon);

    modal.find('#modal-confirm-title').text(title);

    modal.find('#modal-confirm-body').html(body);

    if (callback != null) {
        modal.find('#modal-confirm-ok').off('click');
        modal.find('#modal-confirm-ok').click(function () {
            callback(true);
        });

        modal.find('#modal-confirm-cancel').off('click');
        modal.find('#modal-confirm-cancel').click(function () {
            callback(false);
        });
    }

    $('#modal-confirm').modal({
        backdrop: 'static',
        keyboard: false
    });

    $('#modal-confirm').modal('show');
};




// Characteristic Editor
$(function () {
    $(".characteristics-editor-expand-all").on("click", function () {
        $(this).closest(".characteristics-editor").find(".collapse").collapse('show');

        return false;
    });

    $(".characteristics-editor-collapse-all").on("click", function () {
        $(this).closest(".characteristics-editor").find(".collapse").collapse('hide');

        return false;
    });

    $(".characteristics-editor .collapse").on("show.bs.collapse", function () {
        var $icon = $(this).prev("a[data-toggle=collapse]").find("span");

        $icon.removeClass("icon-arrow-up5");
        $icon.addClass("icon-arrow-down5");

        $(this).find("input, select").prop("disabled", false);
    });

    $(".characteristics-editor .collapse").on("hide.bs.collapse", function () {
        var $icon = $(this).prev("a[data-toggle=collapse]").find("span");

        $icon.removeClass("icon-arrow-down5");
        $icon.addClass("icon-arrow-up5");

        $(this).find("input, select").prop("disabled", true);
    });

    $(".characteristics-editor .collapse:not(:visible)").find("input, select").prop("disabled", true);
});




// Cascading DropDownLists
$(function () {
    $('select[data-toggle=cascade]').each(function () {
        var $parent = $($(this).data('parent'));
        var $child = $(this);

        var dataUrl = $(this).data('url');
        var dataValueField = $(this).data('valuefield');
        var dataTextField = $(this).data('textfield');

        var defaultText = $(this).data('defaulttext');

        $parent.on('change', function () {
            // Remove all Options from the child Select before filling with
            // new Options.
            $child.children().remove();

            // Append the default, if it exists.
            if (defaultText != '' && defaultText != null) {
                $child.append('<option value="">' + defaultText + '</option>');
            }

            if ($(this).val() == '' || $(this).val() == null) {
                // If the parent selected value was changed to the default,
                // force the child to execute change() to start a cascade, then
                // disable the child.
                $child.change();
                $child.prop('disabled', true);
            }
            else {
                // If the parent selected value was not changed to the default,
                // run a JSON query using the child's data-url attribute.
                $.getJSON(dataUrl + $(this).val(), function (data) {
                    $.each(data, function (index, value) {
                        // Note that the default field names are:
                        // dataValueField = "Id", dataTextField = "Name".
                        $child.append('<option value="' + value[dataValueField] + '">' + value[dataTextField] + '</option>');
                    });

                    $child.prop('disabled', false);

                    // Select an initial Option if it exists, then mark that the
                    // initialization has happened.
                    if (!$child.hasClass('cascade-initialized')) {
                        var selectedValue = $child.data('selectedvalue');

                        if (selectedValue != '' && selectedValue != null) {
                            $child.val($child.data('selectedvalue'));
                        }

                        $child.addClass('cascade-initialized')
                    }

                    // Force the child to execute change() to start a cascade.
                    $child.change();
                });
            }
        });
    });

    // Mark all parents who are not also children using:
    // data-toggle = "cascade". This is so that on initial load, only
    // Selects at the top of a cascade are forced to execute change().
    $('select[data-toggle=cascade]').each(function () {
        $($(this).data('parent')).attr('data-toggle', 'cascade');
    });

    // On initial load, execute change() on all Selects that are
    // marked as cascading but do not have a parent.
    $('select[data-toggle=cascade]').each(function () {
        var parent = $(this).data('parent');

        if (parent == '' || parent == null) {
            $(this).change();
        }
    });
});




// Kendo Grid improvements
function kGridDataBound(e) {
    $(e.sender.element)
        .children('table[role=grid]')
        .wrap('<div style=\"overflow-x:auto;\"></div>');
};

function kGridError(e) {
    alert({
        type: 'warning',
        icon: 'icon-warning2',
        title: 'Warning',
        body: 'An error has occurred retrieving data for the grid.'
    });
};




// Kendo Scheduler improvements
function kSchedulerDataBinding(e) {
    var scheduler = e.sender;

    if (scheduler.view().name == 'month') {
        if (e.items != null) {
            var dates = {};

            $.each(e.items, function (index, element) {
                var startDay = new Date(element.start).setHours(0, 0, 0, 0);
                var endDay = new Date(element.end).setHours(0, 0, 0, 0);

                for (var i = new Date(element.start) ; i <= element.end; i.setDate(i.getDate() + 1)) {
                    var key = kendo.toString(i, 'd');

                    if (!(key in dates)) {
                        dates[key] = 0;
                    }

                    dates[key]++;
                }
            });

            scheduler.element.find('td[role=gridcell]').each(function (index, cell) {
                var template = $(cell).find('.k-custom-nav-day');
                var date = template.data('date');

                if (date in dates) {
                    $(cell).height(50 + dates[date] * 200);
                }
                else {
                    $(cell).height(80);
                }

                $(cell).data('defaultHeight', $(cell).height());
            });
        }
        else {
            scheduler.element.find('td[role=gridcell]').each(function (index, cell) {
                $(cell).height($(cell).data('defaultHeight'));
            });
        }
    }
};

function kSchedulerDataBound(e) {
    var scheduler = e.sender;
    var events = scheduler.element.find('.k-event');

    if (!scheduler.element.hasClass('scheduler-customizations-bound')) {
        scheduler.element.on('click', '.k-scheduler-monthview .k-custom-nav-day', function () {
            scheduler.date(new Date($(this).data('date')));
            scheduler.view('day');
        });

        scheduler.element.on('mouseenter', '[data-toggle="popover"]:not(.event-customizations-bound)', function () {
            $(this).popover({
                html: true,
                template: '<div class="popover" role="tooltip"><div class="arrow"></div><div class="popover-content"></div></div>',
                trigger: 'hover',
                container: 'body'
            });

            $(this).popover('show');

            $(this).addClass('event-customizations-bound');
        });

        scheduler.element.addClass('scheduler-customizations-bound');
    }

    $(events).filter(':not(.event-customizations-bound)').each(function (index, event) {
        var occurrence = scheduler.occurrenceByUid($(event).data('uid'));

        $(event).data('id', occurrence.Id);

        if (occurrence.IsPublic) {
            $(event).addClass("k-event-public");
        }
        else {
            $(event).addClass("k-event-private");
        }

        $(event).addClass("event-customizations-bound");
    });

    if (scheduler.view().name == 'month') {
        scheduler.element.find('tr[role=row]').each(function (index, row) {
            var rowEvents = getElementsInTarget(row, events);

            if (rowEvents.length > 0) {
                var rowEventsAboveRowEvent = {};

                $(rowEvents).each(function (index, rowEvent) {
                    rowEventsAboveRowEvent[$(rowEvent).data('uid')] = getElementsAboveTarget(rowEvent, rowEvents);

                    $(rowEvent).height("");
                    $(rowEvent).width($(rowEvent).width() - ($(rowEvent).outerWidth(true) - $(rowEvent).outerWidth()));
                });

                $(rowEvents).each(function (index, rowEvent) {
                    var rowEventsAbove = rowEventsAboveRowEvent[$(rowEvent).data('uid')];

                    if (rowEventsAbove.length > 0) {
                        var elementsAboveBottom = getBottomOfElements(rowEventsAbove);

                        var rowEventOffset = $(rowEvent).offset();
                        rowEventOffset.top = elementsAboveBottom + ($(rowEvent).outerWidth(true) - $(rowEvent).outerWidth());
                        $(rowEvent).offset(rowEventOffset);
                    }
                });

                var eventsBelow = getElementsBelowTarget(row, events);
                var cellHeight = getBottomOfElements(rowEvents) - getTopOfElements(rowEvents) + 50;
                var rowHeightBefore = $(row).height();

                $(row).find('td[role=gridcell]').each(function (index, cell) {
                    $(cell).height(cellHeight);
                });

                var rowHeightAfter = $(row).height();

                $(eventsBelow).each(function (index, eventBelow) {
                    if ($.inArray(eventBelow, rowEvents)) {
                        var eventBelowOffset = $(eventBelow).offset();
                        eventBelowOffset.top = eventBelowOffset.top + (rowHeightAfter - rowHeightBefore);
                        $(eventBelow).offset(eventBelowOffset);
                    }
                });
            }
        });
    }
    else if (scheduler.view().name == 'week') {
        $(events).each(function (index, event) {
            $(event).css("min-height", $(event).height())
        });
    }
};

function getTopOfElements(elements) {
    var minTop = null;

    $(elements).each(function (index, element) {
        var elementTop = $(element).offset().top;

        if (minTop != null) {
            if (elementTop < minTop) {
                minTop = elementTop;
            }
        }
        else {
            minTop = elementTop;
        }
    });

    return minTop;
};

function getBottomOfElements(elements) {
    var maxBottom = null;

    $(elements).each(function (index, element) {
        var elementBottom = $(element).offset().top + $(element).height();

        if (maxBottom != null) {
            if (elementBottom > maxBottom) {
                maxBottom = elementBottom;
            }
        }
        else {
            maxBottom = elementBottom;
        }
    });

    return maxBottom;
};

function getElementsInTarget(target, elements) {
    var filteredElements = [];
    var targetTop = $(target).offset().top;
    var targetHeight = $(target).height();

    $(elements).each(function (index, element) {
        if (target != element) {
            var elementTop = $(element).offset().top;
            var elementHeight = $(element).height();

            if (targetTop < elementTop && elementTop < (targetTop + targetHeight)) {
                filteredElements.push(element);
            }
        }
    });

    return filteredElements;
};

function getElementsAboveTarget(target, elements) {
    var filteredElements = [];
    var targetOffset = $(target).offset();
    var targetWidth = $(target).width();

    $(elements).each(function (index, element) {
        if (target != element) {
            var elementOffset = $(element).offset();
            var elementWidth = $(element).width();

            if (targetOffset.top > elementOffset.top) {
                if (elementOffset.left < (targetOffset.left + targetWidth) && (elementOffset.left + elementWidth) > targetOffset.left) {
                    filteredElements.push(element);
                }
            }
        }
    });

    return filteredElements;
};

function getElementsBelowTarget(target, elements) {
    var filteredElements = [];
    var targetOffset = $(target).offset();
    var targetHeight = $(target).height();
    var targetWidth = $(target).width();

    $(elements).each(function (index, element) {
        if (target != element) {
            var elementOffset = $(element).offset();
            var elementHeight = $(element).height();
            var elementWidth = $(element).width();

            if ((targetOffset.top + targetHeight) < elementOffset.top) {
                if (elementOffset.left < (targetOffset.left + targetWidth) && (elementOffset.left + elementWidth) > targetOffset.left) {
                    filteredElements.push(element);
                }
            }
        }
    });

    return filteredElements;
};

// Set up generic elements
$(document).ready(function () {
    $(".datePicker").kendoDatePicker({
        format: "MM/dd/yyyy"
    });

    $(".dateMonthDayPicker").kendoDatePicker({
        start: "month",
        depth: "month",
        format: "MM/dd"
    });
});

// allow password hit functionality
$(document).ready(function () {
    $(".password-hint-toggle").on("click", function (e) {
        var control = $(e.target).closest(".password-hint-toggle").parent().find("input");
        if ($(control).attr("type") === "password") {
            $(control)[0].setAttribute('type', 'text');
            $(e.target).closest(".password-hint-toggle").children(".password-hint-icon").removeClass("icon-eye2").addClass("icon-eye-blocked2");
            $(e.target).closest(".password-hint-toggle").children(".password-hint-label").text("Hide");
        } else {
            $(control)[0].setAttribute('type', 'password');
            $(e.target).closest(".password-hint-toggle").children(".password-hint-icon").addClass("icon-eye2").removeClass("icon-eye-blocked2");
            $(e.target).closest(".password-hint-toggle").children(".password-hint-label").text("Show");
        }
    });
});