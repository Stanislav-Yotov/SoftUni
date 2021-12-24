function solve(fruit, grams, pricePerKillo){
    let weightInKillo = grams / 1000;
    let money = pricePerKillo * weightInKillo;

    return `I need $${money.toFixed(2)} to buy ${weightInKillo.toFixed(2)} kilograms ${fruit}.`
}

console.log(solve('orange', 2500, 1.80));
console.log(solve('apple', 1563, 2.35));