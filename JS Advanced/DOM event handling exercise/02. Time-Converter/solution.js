function attachEventsListeners() {
    let days = document.getElementById('days');
    let hours = document.getElementById('hours');
    let minutes = document.getElementById('minutes');
    let seconds = document.getElementById('seconds');

    let token = {
        days: 1,
        hours: 24,
        minutes: 1440,
        seconds: 86400
    };

    document.getElementById('daysBtn').addEventListener('click', convertTime);
    document.getElementById('hoursBtn').addEventListener('click', convertTime);
    document.getElementById('minutesBtn').addEventListener('click', convertTime);
    document.getElementById('secondsBtn').addEventListener('click', convertTime);

    function convert(value, unit){
        let days = value / token[unit];

        return {
            days: days,
            hours: days*token.hours,
            minutes: days*token.minutes,
            seconds: days*token.seconds
            
        };
    }

    function convertTime(e){
        let input = e.target.parentElement.querySelector('input[type="text"]');
        let time = convert(Number(input.value), input.id)
        days.value = time.days;
        hours.value = time.hours;
        minutes.value = time.minutes;
        seconds.value = time.seconds;
    }
    
}