function toggle() {
    let divElement = document.getElementById('extra');
    let buttonElement = document.getElementsByClassName("button")[0];

    if (divElement.style.display == 'none') {
        divElement.style.display = 'block'; 
        buttonElement.textContent = 'Less';
    } else {
        divElement.style.display = 'none'; 
        buttonElement.textContent = 'More';
    }
}