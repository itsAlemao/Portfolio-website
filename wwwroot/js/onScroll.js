window.onscroll = function() {
    if (window.scrollInfoService != null)
        window.scrollInfoService.invokeMethodAsync('OnScroll', window.pageYOffset);
}

window.RegisterScrollInfoService = (scrollInfoService) => {
    window.scrollInfoService = scrollInfoService;
}

//trova il rettangolo dell'elemento, RITORNA -1 SE FALLISCE!!!
window.getMarginHeight = function (id) {
    var el = document.getElementById(id)
    return el ? Math.round(el.getBoundingClientRect().top) : -1
}