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
    if (bookmark.innerHTML === "bookmark") {
        savedNotification();
        return;
    }


   

    /// const target = document.getElementById("alertDiv");
//    window.onload = setInterval(() => target.style.opacity = '0', 3000);
}

async function savedNotification() {

        if ($("#savedAlert").find("div#savedAlert2").length == 0) {
            $("#savedAlert").append("<div class='alert alert-success alert-dismissable' id='savedAlert2'> <button type='button' class='close' data-dismiss='alert'  aria-hidden='true'>&times;</button> <strong>Saved!</strong> message sent successfully.</div>");
        }
    $("#savedAlert").css("display", "");
    await sleep(2000);
  //  $("#savedAlert").css("display", "none");
}
function unsavedNotification() {

}
function sleep(time) {
    return new Promise(resolve => setTimeout(resolve, time));
}