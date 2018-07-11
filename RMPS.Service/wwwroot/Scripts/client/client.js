
function customFieldWithData(data, customFieldNumber) {

    var id = document.getElementById("CustomFieldId" + customFieldNumber);
    var name = document.getElementById("CustomFieldName" + customFieldNumber);
    var text = document.getElementById("CustomFieldText" + customFieldNumber);
    
    if (id !== null && id !== undefined) {
        id.setAttribute("value", data.Id);
    }
    if (name !== null && name !== undefined) {
        name.setAttribute("value", data.Name);
        name.setAttribute("style", "font:normal");
        name.style.display = "block";
    }
    if (text !== null && text !== undefined) {
        text.setAttribute("value", "");
        text.style.display = "block";
    }
};


function customFieldNoData(customFieldNumber) {

    $("#CustomFieldId" + customFieldNumber).empty().val('');
    $("#CustomFieldText" + customFieldNumber).empty().val('');

    if (customFieldNumber === "1") {
        document.getElementById("CustomFieldName" + customFieldNumber).setAttribute("value", "No custom fields for this client");
        document.getElementById("CustomFieldName" + customFieldNumber).style.fontStyle = "italic";
    }
    else {
        document.getElementById("CustomFieldName" + customFieldNumber).style.display = "none";
    }

    document.getElementById("CustomFieldText" + customFieldNumber).style.display = "none";
};


function initializeCustomFields(customField) {

    if (customField !== null && customField !== '') {
        customField.setAttribute("tabindex", "-1");
        customField.style.fontStyle = "italic";
        customField.setAttribute("disabled", "disabled");
    }
};


$(document).ready(function () {

    initializeCustomFields(document.getElementById("CustomFieldName1"));
    initializeCustomFields(document.getElementById("CustomFieldName2"));

    document.getElementById("CustomFieldText1").style.display = "none";
    document.getElementById("CustomFieldName2").style.display = "none";
    document.getElementById("CustomFieldText2").style.display = "none";

    //hide by default. we will show when we have a proper list to show.
    $('#DepartmentIdRow').hide();
});


$(document).ready(function () {
    $('#ClientId').on("change", function () {

        var clientId = $('#ClientId').val();

        if (clientId !== '' && clientId !== null) {

            $.ajax({
                url: "/Administration/UserRole/GetClientCustomFieldsOnClientChange",
                type: "get",
                dataType: "json",
                data: { 'id': clientId },
                success: function (result) {
                    
                    if (result[0] !== null && result[0] !== undefined) {
                        customFieldWithData(result[0], "1");
                    }
                    else {
                        customFieldNoData("1");
                    }
                    if (result[1] !== null && result[1] !== undefined) {
                        customFieldWithData(result[1], "2");
                    }
                    else {
                        customFieldNoData("2");
                    }
                },
                error: function (xhr, ajaxOptions, thrownError) {
                    alert(thrownError);
                }
            });

            $.ajax({
                url: "/Administration/UserRole/AsyncDepartments",
                type: "get",
                dataType: "json",
                data: { 'id': clientId },
                success: function (result) {

                    $("#DepartmentId").empty();
                    $("#DepartmentId").append("<option value=''>(select an option)</option>");

                    $.each(result, function (i, value) {
                        $("#DepartmentId").append($("<option></option>").val(value.Id).html(value.Name));
                    });

                    if (result.length === 1) {
                        $('#DepartmentId').prop('selectedIndex', 1);
                        $('#DepartmentIdRow').hide();
                    }
                    else {
                        $('#DepartmentId').prop('selectedIndex', 0);
                        $('#DepartmentIdRow').show();
                    }
                },
                error: function (xhr, ajaxOptions, thrownError) {
                    alert(thrownError);
                }
            });
        }
    })
    $("input[name^='CharacteristicList[Residency Year_']").on("click", function () {
        var idClicked = $(this).prop("name").substr($(this).prop("name").indexOf("_") + 1, ($(this).prop("name").indexOf("]") - $(this).prop("name").indexOf("_")) - 1);
        var checkedClicked = $(this).prop("checked");
        if (idClicked != 'Fellow') {
            $("input[name^='CharacteristicList[Residency Year_']").each(function() {
                var idIndex = $(this).prop("name").substr($(this).prop("name").indexOf("_") + 1, ($(this).prop("name").indexOf("]") - $(this).prop("name").indexOf("_")) - 1);
                if (idIndex != 'Fellow') {
                    if (idIndex < idClicked && checkedClicked) {
                        $(this).prop("checked", true);
                    }
                    if (idIndex > idClicked && !checkedClicked) {
                        $(this).prop("checked", false);
                    }
                }
            });
        }
    })
});
