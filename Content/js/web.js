$(document).ready(function (e) {
    var touch = $('#resp-menu');
    var menu = $('.menu');
    $(touch).on('click', function (e) {
        e.preventDefault();
        menu.slideToggle();
    });
    $(window).resize(function () {
        var w = $(window).width();
        if (w > 767 && menu.is(':hidden')) {
            menu.removeAttr('style');
        }
    });
    $('.sub-menu').parent('li').addClass('has-child');
    if ($(window).width() < 768) {
        $('.sub-menu').prev('a').attr('href', 'javascript:void(0)');
        $('.sub-menu').prev('a').click(function () {
            $(this).next().slideToggle();
        });
        $('.submenu').prev('a').attr('href', 'javascript:void(0)');
        $('.submenu').prev('a').click(function () {
            $(this).next().slideToggle();
        });
    };
})