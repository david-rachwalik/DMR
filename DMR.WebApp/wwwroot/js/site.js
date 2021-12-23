// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $navTabs = $('ul.nav-tabs');
    $navTabs.children("li").first().children("a").click();
    // Enable Bootstrap tooltips everywhere // https://getbootstrap.com/docs/4.6/components/tooltips
    $('[data-bs-toggle="tooltip"]').tooltip();

    // Activate first tab if exists
    const erpgeNav = $('#erpge .container .nav');
    if (erpgeNav) {
        const erpgeNavLinks = erpgeNav.find('.nav-link');
        const erpgeNavLinkFirst = erpgeNavLinks.first('.nav-link');
        if (erpgeNavLinkFirst) { erpgeNavLinkFirst.click(); }
    }
});
