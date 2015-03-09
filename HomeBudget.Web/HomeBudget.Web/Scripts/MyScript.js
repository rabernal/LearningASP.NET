$(function () {
    var ajaxFormSubmit = function () {
        var form = $(this);
        var options = {
            url: form.attr("action"),
            type: form.attr("method"),
            data: form.serialize()
        };

        $.ajax(options).done(function (data) {
            var target = $(form.attr("data-target"));
            var myEffectWrap = $(data);
            target.replaceWith(myEffectWrap);
            myEffectWrap.effect("slide");
            myEffectWrap.effect("highlight");
        });
        //$('#userList').css('background-color', 'yellow');
        // prevent the browser form goint by itself to the server. 
        return false;
    };

    //var submitAutoCompleteForm = function (UIEvent, ui) {
    //    var input = $(this);
    //    input.val(ui.item.label);

    //    var form = input.parent("form:first");
    //    form.submit();
    //};

    //var createAutocomplete = function () {
    //    var input = $(this);

    //    var options = {
    //        source: input.attr("data-autocomplete"),
    //        select: submitAutoCompleteForm
    //    };
    //    input.autocomplete(options);
    //};
    $('input #checkC').click(function () {
        alert($(this));
    });
    

    //$("form[data-ajax='true']").submit(ajaxFormSubmit);
    //$("input[data-calculate]").each(createAutocomplete);
    //$("input[type=checkbox]").on("click", countChecked);
 

}());