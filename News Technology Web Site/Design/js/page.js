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
    autoSlider();
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
        let newHtml = html.replace(regExp, "<mark>" + text + "</mark>");
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
function swicherImg(counter) {
    let imgSwicher = document.getElementById("imgSwicher");
    switch (counter) {
        case '1':
            imgSwicher.src = "../imgs/posts/slider/galaxyTabS7/galaxy-tab-s7-one.jpg";
            break;
        case '2':
            imgSwicher.src = "../imgs/posts/slider/galaxyTabS7/galaxy-tab-s7-two.jpg";
            break;
        case '3':
            imgSwicher.src = "../imgs/posts/slider/galaxyTabS7/galaxy-tab-s7-three.jpg";
            break;
        case '4':
            imgSwicher.src = "../imgs/posts/slider/galaxyTabS7/galaxy-tab-s7-fore.jpg";
            break;
        default:
    }
}
let time = 0;
let isChecked = false;
function autoSlider() {
    mySlider = w3.slideshow(".slider", time);
    if (!isChecked) {
        time = 0;
        isChecked = true;
    } else {
        time = 2000;
        isChecked = false;
    }
}