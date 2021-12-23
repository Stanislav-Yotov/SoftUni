function solve(steps, footLength, speed){
    let distanceInMeters = steps * footLength;
    let distanceInKilometers = distanceInMeters / 1000;
    let timeInMinutes = (distanceInKilometers / speed) * 60;

    for (let i = 500; i < distanceInMeters; i+= 500) {
        timeInMinutes += 1;
        
    }

    let seconds;
    let minutes;
    let hours;

    if (timeInMinutes >= 60) {
        hours = timeInMinutes / 60;
        minutes = Math.floor(timeInMinutes - hours * 60);
    }else{
        hours = 0;
        minutes = Math.floor(timeInMinutes);
    }

    seconds = Math.round((timeInMinutes - Math.floor(timeInMinutes))*60);

    console.log(`${hours.toString().padStart(2, '0')}:${minutes.toString().padStart(2, '0')}:${seconds.toString().padStart(2, '0')}`);
}

solve(4000, 0.60, 5);
solve(2564, 0.70, 5.5);