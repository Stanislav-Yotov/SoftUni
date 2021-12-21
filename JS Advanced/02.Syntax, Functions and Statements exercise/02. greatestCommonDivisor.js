function solve(num1, num2){
    let smallerNum = Math.min(num1, num2);
    let commonDivisor = 0;
    for (let i = 0; i <= smallerNum; i++) {
        if (num1 % i === 0 && num2 % i === 0 ) {
            commonDivisor = i;
        }
        
    }
    return commonDivisor;
}

console.log(solve(15, 5));
console.log(solve(2154, 458));