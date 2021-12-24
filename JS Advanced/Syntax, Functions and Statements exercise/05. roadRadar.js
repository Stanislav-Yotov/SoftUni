function solve(speed, area){
    let maxSpeed;
    let result;
    let message;

    switch (area) {
        case 'motorway':
            maxSpeed = 130;
            break;
        case 'interstate':
            maxSpeed = 90;
            break;
        case 'city':
            maxSpeed = 50;
            break;
        case 'residential':
            maxSpeed = 20;
            break; 
    }

    if (speed <= maxSpeed) {
        result = `Driving ${speed} km/h in a ${maxSpeed} zone`;
    }else{
        let difference = speed - maxSpeed;
        if (difference <= 20) {
            message = 'speeding';
        }else if (difference <= 40) {
            message = 'excessive speeding';
        }else{
            message = 'reckless driving'; 
        }
        result = `The speed is ${speed - maxSpeed} km/h faster than the allowed speed of ${maxSpeed} - ${message}`;
    }

    console.log(result);
}

solve(40, 'city');
solve(21, 'residential');
solve(120, 'interstate');
solve(200, 'motorway');
