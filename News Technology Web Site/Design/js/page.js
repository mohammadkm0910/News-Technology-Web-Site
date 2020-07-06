$(document).ready(function() {
    $(window).scroll(function() {
        if ($(window).scrollTop() > 45) {
            $(".nav-top").css("position","fixed");
        } else {
            $(".nav-top").css("position", "relative")
        }
    });
    $(".drawer").click(function () {
        $("#expandedDrawer").toggle("1000");
    });
});
function scaleImg(x) {
    x.classList.toggle("zoom-in");
}
function myDrawer(x) {
    x.classList.toggle("click");
}
function onTabs(tabs) {
    let i;
    let x = $(".forms");
    for (i = 0 ; i < x.length ; i++){
        x[i].style.display = "none";
    }
    document.getElementById(tabs).style.display = "block";
}
$("#search").click(function () {
    clearSearch();
    let text = $("#text").val();
    let regExp = new RegExp(text, "g");
    $("p").each(function () {
        let html = $(this).html();
        let newHtml = html.replace(regExp, "<i style='background:yellow;color:black;font-style:normal'>" + text + "</i>");
        $(this).html(newHtml);
    });
});
function clearSearch() {
    $("p").each(function () {
        $(this).find("i").each(function () {
            $(this).replaceWith($(this).html());
        });
    });
}