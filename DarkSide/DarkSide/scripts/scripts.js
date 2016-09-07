/// <reference path="jquery-1.10.2.js" />

$(function () {
    if ($("#side").text() == "dark") {
        $("body").addClass("dark")
        $("#btn-yes").click(YesBtnClick);
    }
    else {
        $("body").addClass("light")
    }
    $("#btn-no").click(NoBtnClick);
});

function NoBtnClick() {
    $("footer").html("<p>Ok!</p>");
}

function YesBtnClick() {
    alert("LOL. There is no way back!!!");
}