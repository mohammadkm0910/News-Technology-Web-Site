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