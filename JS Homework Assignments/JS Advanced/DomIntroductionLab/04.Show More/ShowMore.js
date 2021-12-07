function showText() {
    let spanElement = document.getElementById('text');
    let aElement = document.getElementById('more');

    if (spanElement.style.display == 'none') {
        spanElement.style.display = 'inline'; 
        aElement.style.display = 'none';
    } 
}