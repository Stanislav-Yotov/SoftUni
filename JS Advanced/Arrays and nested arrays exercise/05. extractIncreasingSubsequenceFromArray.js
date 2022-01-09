function solve(arr){
    let filteredArr = [arr[0]];

    if (arr.length > 1) {
        arr.reduce((acc, current) => {
            if (current >= filteredArr[filteredArr.length - 1]) {
                filteredArr.push(current);
            }
        });
       
        
    }

    return filteredArr;
}

console.log(solve([1, 
    3, 
    8, 
    4, 
    10, 
    12, 
    3, 
    2, 
    24]
    ));
