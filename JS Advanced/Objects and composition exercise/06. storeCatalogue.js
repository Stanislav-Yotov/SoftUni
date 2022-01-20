function solve(input) {
    const result = [];
    for (const token of input) {
        let [name, price] = token.split(' : ');
        const obj = {
            name,
            price: Number(price),
        }
        result.push(obj);
    }
    result.sort((a, b) => a.name.localeCompare(b.name));
    let letter = null;
    for (const token of result) {
        if (token.name[0] !== letter) {
            letter = token.name[0];
            console.log(letter);
        }

        console.log(`  ${token.name}: ${token.price}`);
    }

}

solve(['Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10']);