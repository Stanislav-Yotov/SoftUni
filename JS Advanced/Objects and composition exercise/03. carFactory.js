function solve(car){
    let obj = {};

    function getEngine(power){
        if (power <= 90) {
            return { power: 90, volume: 1800 };
        } else if(power <= 120){
            return { power: 120, volume: 2400 };
        } else{
            return { power: 200, volume: 3500 };
        }
    }

    const properWheelSize = car.wheelsize % 2 == 0 ? car.wheelsize -1 : car.wheelsize;
    obj.model = car.model;
    obj.engine = getEngine(car.power);
    obj.carriage = {type: car.carriage, color: car.color};
    obj.wheelsize = new Array(4).fill(properWheelSize, 0, 4);

    return obj;
}

console.log(solve({ model: 'VW Golf II', power: 90, color: 'blue', carriage: 'hatchback', wheelsize: 14 }));
console.log(car.model);