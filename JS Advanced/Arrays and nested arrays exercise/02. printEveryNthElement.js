function solve(arr, number){
    let filteredArr = arr.filter((num, index) => index % number == 0)

    return filteredArr;
}

console.log(solve(['5', 
'20', 
'31', 
'4', 
'20'], 
2
));