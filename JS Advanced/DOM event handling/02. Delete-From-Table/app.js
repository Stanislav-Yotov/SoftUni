function deleteByEmail() {
    let tableElements = document.querySelectorAll('tbody tr');
    let inputEmail = document.getElementsByName('email');
    let email = inputEmail[0].value;
    let resultElement = document.getElementById('result');
    inputEmail[0].value = '';

    for (const el of tableElements) {
        if (el.textContent.includes(email)) {
            el.remove();
            resultElement.textContent = 'Deleted.';
            break;
        }else{
            resultElement.textContent = 'Not found.';
        }
    }

}