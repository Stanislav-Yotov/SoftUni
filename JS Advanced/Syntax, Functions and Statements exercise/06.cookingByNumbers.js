function solve(num, op1, op2, op3, op4, op5){
    let number = Number(num);
    let cmdArgs = [op1, op2, op3, op4, op5];
    for(let i = 0; i < cmdArgs.length; i++){
        let command = cmdArgs[i];
        switch(command){
            case 'chop':
                number /= 2;
                break;
            case 'dice':
                number = Math.sqrt(number);
                break;
            case 'spice':
                number++;
                break;
            case 'bake':
                number *= 3;
                break;
            case 'fillet':
                number *= 0.8;
                break;
        }
        console.log(number);
    }
}

solve('32', 'chop', 'chop', 'chop', 'chop', 'chop');
solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet');