function bookmark(element) {

    if (element.innerHTML === "bookmark_added") {
        element.innerHTML = "bookmark";
        element.style.color = "#808080";
        return;
    }
    element.innerHTML = "bookmark_added";
    element.style.color = "#2c4dd1";
 
    return;
    
}