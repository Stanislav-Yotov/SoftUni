function focused() {
    let inputs = Array.from(document.getElementsByTagName('input'));
    inputs.forEach(x => x.addEventListener('focus', onFocus));
   

    let secondInputs = Array.from(document.getElementsByTagName('input'));
    secondInputs.forEach(x => x.addEventListener('blur', blured));

    function onFocus(e) {
        e.currentTarget.parentNode.classList.add('focused');
    }


    function blured(e) {
        e.currentTarget.parentNode.classList.remove('focused');
        
    }
}