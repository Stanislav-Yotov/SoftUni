function subSum(arr, startIndex, endIndex) {
    if (!Array.isArray(arr)) {
        return NaN;
    }

    if (startIndex < 0) {
        startIndex = 0;
    }

    if (endIndex >= arr.length) {
        endIndex = arr.length - 1;
    }

    let sum = arr.slice(startIndex, endIndex + 1)
        .map(Number)
        .reduce((a, x) => a + x, 0);

    return sum;
}

console.log(subSum([10, 20, 30, 40, 50, 60], 3, 300));