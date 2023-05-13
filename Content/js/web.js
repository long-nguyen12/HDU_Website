$("#carousel").owlCarousel({
    autoplay: true,
    lazyLoad: true,
    loop: true,
    margin: 10,
    responsiveClass: true,
    autoHeight: true,
    nav: true,
    items: 3,
    responsive: {
        480: { items: 1 }, // from zero to 480 screen width 4 items
        768: { items: 2 }, // from 480 screen widthto 768 6 items
        1024: {
            items: 3   // from 768 screen width to 1024 8 items
        }
    },
});
