var currentPrerequisiteAnswers = {}
var questionAnswerMap = {}

var elementsToShow;

$(document).ready(function () {
    // Set all the hidden checkbox inputs to the unchecked values
    $("input[type='checkbox']").each(function (i, e) {
        setHiddenInputForCheckbox(e);
    });

    $("input[type='checkbox']").change(function (e) {
        setHiddenInputForCheckbox(e.target);
    });

    setupValueChanges();
    showConditionalQuestions(0)
});

function setupValueChanges() {
    $('input[type=radio]').on('change', onRadioButtonChange);
    $('input[type=checkbox]').on('change', onCheckboxChange);
    $('select').on('change', onSelectListChange);

    elementsToShow = $('[data-prerequisiteanswers][data-prerequisiteanswers!=""]')

    // Initial value load
    $('input[type=radio]:checked').each(function (i, o) {
        target = $(o);
        
        var questionId = target.attr('name');
        var answerId = target.attr('value');

        updateAnswerStatus(questionId, answerId, true);
    });

    // Initial value load
    $('input[type=checkbox]:checked').each(function (i, o) {
        target = $(o);

        var questionId = target.data('questionid');
        var inputElement = $('#' + questionId);

        var answerId = inputElement.attr('value');

        updateAnswerStatus(questionId, answerId, true);
    });

    // Initial value load
    $('select').each(function (i, o) {
        target = $(o);

        var questionId = target.attr('name');
        var answerId = target.val();

        // By default, the answers will be blank
        if (answerId !== '') {
            updateAnswerStatus(questionId, answerId, true);
        }
    })

    showConditionalQuestions();
}

function updateAnswerStatus(questionId, answerId, selected) {
    // Holds all the question/answer maps that have been seen
    if (questionAnswerMap[questionId] === undefined)
        questionAnswerMap[questionId] = {};

    // questionAnswerMap is being used like a hashset
    questionAnswerMap[questionId][answerId] = null;

    // currentPrerequisiteAnswers holds the activated *answers*, not the questions.

    // Iterate all the answers to this question. If it's the one we're working on, set it to selected (usually true)
    // If it's not the one we're working on, set it to false.
    for (var relatedAnswerId in questionAnswerMap[questionId]) {
        if (relatedAnswerId === answerId) {
            currentPrerequisiteAnswers[relatedAnswerId] = selected;
        }
        else {
            currentPrerequisiteAnswers[relatedAnswerId] = false;
        }

        if (currentPrerequisiteAnswers[relatedAnswerId] === false && typeof relatedAnswerId !== "undefined" && relatedAnswerId.length > 0) {
            $('[data-prerequisiteanswers=' + relatedAnswerId + ']').each(function (i, o) {
                var question = $(o);

                question.find('input[type=radio]:checked').each(function (j, element) {
                    var target = $(element);
                    var subQuestionId = target.attr('name');
                    var subAnswerId = target.attr('value');

                    target.attr('checked', false);

                    updateAnswerStatus(subQuestionId, subAnswerId, false);
                });

                question.find('input[type=checkbox]:checked').each(function (j, element) {
                    var target = $(element);
                    var subQuestionId = target.data('questionid');
                    var inputElement = $('#' + questionId);

                    var subAnswerId = inputElement.attr('value');

                    target.attr('checked', false);
                    setHiddenInputForCheckbox(target);

                    updateAnswerStatus(subQuestionId, subAnswerId, false);
                });

                question.find('select').each(function (j, element) {
                    var target = $(element);
                    var subQuestionId = target.attr('name');
                    var subAnswerId = target.val();

                    target.val('');

                    updateAnswerStatus(subQuestionId, subAnswerId, false);
                });
            });
        }
    }
}

function onRadioButtonChange(e) {
    target = $(e.currentTarget);
    
    var questionId = target.attr('name');
    var answerId = target.attr('value');
    var selected = target.is(':checked');

    updateAnswerStatus(questionId, answerId, selected);
    showConditionalQuestions();
}

function onCheckboxChange(e) {
    target = $(e.currentTarget);

    var questionId = target.data('questionid');
    var selected = target.is(':checked');
    var inputElement = $('#' + questionId);

    var answerId = inputElement.attr('value');
    
    updateAnswerStatus(questionId, answerId, selected);
    showConditionalQuestions();
}

function onSelectListChange(e) {
    target = $(e.currentTarget);
    
    var questionId = target.attr('name');
    var answerId = target.val();
    var selected = true;

    updateAnswerStatus(questionId, answerId, selected);
    showConditionalQuestions();
}

function showConditionalQuestions(time) {
    if (time === undefined || time === null)
        time = 'Fast';

    elementsToShow.each(function (i, element) {
        var shouldShow = false;
        var target = $(element);

        var answerIDs = target.data()['prerequisiteanswers'].split(' ');

        for (var j = 0; j < answerIDs.length; j++)
            if (currentPrerequisiteAnswers[answerIDs[j]] === true) // May be undefined, that is OK - it means false
                shouldShow = true;

        if (shouldShow) {
            target.show(time);
        }
        else {
            target.find('input:text, textarea').val('');
            target.hide(time);
        }
    });
}

function setHiddenInputForCheckbox(checkbox) {
    var checked = checkbox.checked;

    var target = $(checkbox);

    var questionId = target.data("questionid");
    var checkedId = target.data("checked");
    var uncheckedId = target.data("unchecked");

    var inputElement = $("#" + questionId);
    var value;

    if (checked)
        value = checkedId;
    else
        value = uncheckedId;

    inputElement.val(value);
}
