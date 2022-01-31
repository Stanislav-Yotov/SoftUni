function validate() {
    let regex = /[a-z]+@[a-z]+\.[a-z]+/;
    let input = document.querySelector('#email');
    input.addEventListener('change', emailValidation);

    function emailValidation(e){
        if (!regex.test(e.currentTarget.value)) {
            e.currentTarget.classList.add('error');
        } else{
            e.currentTarget.classList.remove('error');
        }
    }
}