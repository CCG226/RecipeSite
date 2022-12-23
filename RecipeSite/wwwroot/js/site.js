// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function loginNotification() {
  
    if ($("#loginAlert").find("div#loginAlert2").length == 0) {
        $("#loginAlert").append("<div class='alert alert-success alert-dismissable' id='loginAlert2'> <button type='button' class='close' data-dismiss='alert'  aria-hidden='true'>&times;</button> <strong>Saved!</strong> message sent successfully.</div>");
    }
    $("#loginAlert").css("display", "");
    await sleep(3000);
    $("#loginAlert").css("display", "none");
}
function sleep(time) {
    return new Promise(resolve => setTimeout(resolve, time));
}