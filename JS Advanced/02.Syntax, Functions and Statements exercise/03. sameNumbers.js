function solve(num){
    let stringNum = String(num);
    let isSame = true;
    let sum = stringNum.length > 0 ? Number(stringNum[0]) : 0;
    for (let i = 0; i < stringNum.length - 1; i++) {
        const element = Number(stringNum[i]);
        const nextElementString = stringNum[i + 1];
        const nextElement = Number(stringNum[i + 1]);
        if (element !== nextElement ) {
            isSame = false;
        }
        sum += nextElement;
    }
    
    console.log(isSame);
    console.log(sum);
}

solve(2222222);
solve(1234);
