function solve(input) {
    let result = [];
    for (const iterator of input) {
        let [town, productName, price] = iterator.split(' | ');
        const productObj = {
            town,
            product: productName,
            price: Number(price),
        };
        if (!result.some(x => x.product === productName)) {
            result.push(productObj);
        }

        const objForComparison = result.find(x => x.product === productName);
        if (price < objForComparison.price) {
            objForComparison.price = price;
            objForComparison.town = town;
        }

    }
    for (const iterator of result) {
        console.log(`${iterator.product} -> ${iterator.price} (${iterator.town})`);
    }

}

solve(['Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10']);