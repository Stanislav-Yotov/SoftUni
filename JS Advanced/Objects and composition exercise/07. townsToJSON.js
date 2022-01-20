function solve(input){
    const towns = [];
    for (let i = 1; i < input.length; i++) {
        let townArr = input[i].split('|').filter(x => x);
        const townObj = {
            Town: townArr[0].trim(),
            Latitude: Number(Number(townArr[1]).toFixed(2)),
            Longitude: Number(Number(townArr[2]).toFixed(2)),
        }
        towns.push(townObj);
        
    }

    return JSON.stringify(towns);
}

console.log(solve(['| Town | Latitude | Longitude |',
                   '| Sofia | 42.696552 | 23.32601 |',
                   '| Beijing | 39.913818 | 116.363625 |']));