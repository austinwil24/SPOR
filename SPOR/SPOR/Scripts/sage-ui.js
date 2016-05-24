//SAGE UI JavaScript

$(document).ready(function () {

    var loc = location.href.toLowerCase();
    var isHomeCurrent = true;

    $('.navbar-nav.sage a').each(function () {
        var nav = $(this);
        if (loc.indexOf(this.href.toLowerCase()) > -1) {
            nav.addClass("current");
            isHomeCurrent = false;
        }
        else {
            nav.removeClass("current");
        }
    });

    if (isHomeCurrent) {
        $('#sagelogo').addClass("current");
    }
    else {
        $('#sagelogo').removeClass("current");
    }

    $(".datepicker").datepicker();

    $('.sage-btn').button();

    $('.tooltip').tooltip();
});