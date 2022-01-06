function solve(matrix){
    let biggestElement = Number.MIN_VALUE;

    for (const arr of matrix) {
        let currentBiggestElement = arr.reduce(function(a, b) { return Math. max(a, b); }, 0);

        if (currentBiggestElement > biggestElement) {
            biggestElement = currentBiggestElement;
        }
    }

    return biggestElement;
}

console.log(solve([[20, 50, 10],[8, 33, 145]]));