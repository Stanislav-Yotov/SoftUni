function solve(size){
    if (size === undefined) {
        size = 5;  
    }
    let row = "";

    for (let i = 0; i < size; i++) {
        for (let j = 0; j < size; j++) {
            
            row += '* ';
        }
        console.log(row);
        row = "";  
    }
}

solve(1);
console.log();
solve(2);
console.log();
solve(5);