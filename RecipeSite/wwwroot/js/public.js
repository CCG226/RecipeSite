function bookmark(element) {
    if (element.innerHTML === "bookmark") {
        element.innerHTML = "bookmark_added";
    }
    else (element.innerHTML === "bookmark_added") {
        element.innerHTML = "bookmark";
    }
    
}