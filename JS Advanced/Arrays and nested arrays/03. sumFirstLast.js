function solve(input){
    let firstNum = Number(input.shift());
    let lastNum = Number(input.pop());
    let result = firstNum + lastNum;

    console.log(result);

}

solve(['20', '30', '40']);
solve(['5', '10']);