function solve(str){
    str = str.toUpperCase();
    let regex = /[A-z0-9]+/g;
    strArray = [...str.matchAll(regex)];
    console.log(strArray.join(', '));

}

solve('hello');
solve('Hi, how are you?');