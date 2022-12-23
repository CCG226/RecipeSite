function bookmarkIconChange(element) {

    if (element.innerHTML === "bookmark_added") {
        element.innerHTML = "bookmark";
        element.style.color = "#808080";
        return;
    }
    element.innerHTML = "bookmark_added";
    element.style.color = "#2c4dd1";
 
    return;
    
}
function bookmarkNotification() {
    let bookmark = document.getElementById("myBookmark");
    if (bookmark.innerHTML === "bookmark_added") {
        savedNotification();
        return;
    }
    unsavedNotification();

}

async function savedNotification() {

        if ($("#savedAlert").find("div#savedAlert2").length == 0) {
            $("#savedAlert").append("<div class='alert alert-success alert-dismissable' id='savedAlert2'> <button type='button' class='close' data-dismiss='alert'  aria-hidden='true'>&times;</button> <strong>Saved!</strong> message sent successfully.</div>");
        }
    $("#savedAlert").css("display", "");
    await sleep(1000);
  $("#savedAlert").css("display", "none");
}
async function unsavedNotification() {

    if ($("#unsavedAlert").find("div#unsavedAlert2").length == 0) {
        $("#unsavedAlert").append("<div class='alert alert-success alert-dismissable' id='unsavedAlert2'> <button type='button' class='close' data-dismiss='alert'  aria-hidden='true'>&times;</button> <strong>Saved!</strong> message sent successfully.</div>");
    }
    $("#unsavedAlert").css("display", "");
    await sleep(1000);
    $("#unsavedAlert").css("display", "none");
}
function sleep(time) {
    return new Promise(resolve => setTimeout(resolve, time));
}