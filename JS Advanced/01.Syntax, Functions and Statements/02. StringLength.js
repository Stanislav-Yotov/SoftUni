function stringLength(firstStr, secondStr, thirdStr){
    let sumLength = firstStr.length + secondStr.length + thirdStr.length;
    let averageLength = Math.floor(sumLength / 3);

    console.log(sumLength);
    console.log(averageLength);
}


stringLength('chocolate', 'ice cream', 'cake');
stringLength('pasta', '5', '22.3');