function solve(arr, num){
    let realRotations = num % arr.length;
    let elements = arr.splice(arr.length - realRotations, realRotations);

    arr.splice(0,0, ...elements);
    return arr.join(' ');
}

console.log(solve(['1', 
'2', 
'3', 
'4'], 
2
));

console.log(solve(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15
));