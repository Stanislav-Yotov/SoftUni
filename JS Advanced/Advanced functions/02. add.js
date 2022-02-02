function solve(n){
    let num = Number(n);
    return function(m){
        let num2 = Number(m);
        return num + num2;
    }
}

let add5 = solve(5);
console.log(add5(2));
console.log(add5(3));
