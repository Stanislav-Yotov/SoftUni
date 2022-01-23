function subtract() {
    let numOne = document.getElementById('firstNumber').value;
    let numTwo = document.getElementById('secondNumber').value;

    document.getElementById('result').textContent = Number(numOne) - Number(numTwo); 
}