$(".SHOW_menu_left").click(function () {
    var data = $(this).attr('data');
    var data_text = $(this).html();
    if (data_text == "+") {
        $(".SHOW_menu_left").each(function (index) {
            if ($(this).html() == "-") {
                $(this).html('+');
            }
        });
        $(this).html("-");
        $(".dv_list_dmsp_2").hide('500');
        $(".ul-data-" + data).show('500');
    }
    else if (data_text == "-") {
        $(this).html("+");
        $(".ul-data-" + data).hide('500');
    }
});