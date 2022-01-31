function attachGradientEvents() {
    let divElement = document.getElementById('gradient');
    let resultElement = document.getElementById('result');
    divElement.addEventListener('mousemove', getPercentage);

    function getPercentage(e){
        resultElement.textContent = `${Math.floor((e.offsetX / divElement.clientWidth ) * 100)}%`;
    }
}