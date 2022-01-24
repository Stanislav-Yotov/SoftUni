function toggle() {
    const buttonElement = document.querySelector('.button');
    const textDIV = document.getElementById('extra');

    buttonElement.textContent = buttonElement.textContent == 'More' ? 'Less' : 'More';
    textDIV.style.display = textDIV.style.display == 'none' || textDIV.style.display == '' ?
    textDIV.style.display = 'block' : textDIV.style.display = 'none';
}