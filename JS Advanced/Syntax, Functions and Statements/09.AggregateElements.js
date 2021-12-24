function solve(arr){
    let sum = 0;
    let inversedSum = 0;
    let concat = '';

    sum = arr.reduce((a, b) => a + b, 0);
    inversedSum = arr.reduce((a,b) => a + 1/b, 0);
    concat = arr.join("")

    console.log(sum);
    console.log(inversedSum);
    console.log(concat);
}

solve([1, 2, 3]);
solve([2, 4, 8, 16]);