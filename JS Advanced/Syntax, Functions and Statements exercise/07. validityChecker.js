function solve(x1, y1, x2, y2){
 
    if (Number.isInteger(result(x1, y1, 0, 0))) {
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    } else {
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }
 
    if (Number.isInteger(result(x2, y2, 0, 0))) {
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    } else {
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }
 
    if (Number.isInteger(result(x1, y1, x2, y2))) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    } else {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }

    
    function result(x1, y1, x2, y2) {
        let xDist = x1 - x2;
        let yDist = y1 - y2;
        return Math.sqrt(xDist**2 + yDist**2);
    }
}

solve(3, 0, 0, 4);
solve(2, 1, 1, 1);