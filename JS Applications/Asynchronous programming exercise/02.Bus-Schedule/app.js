function solve() {
    let baseURL = 'http://localhost:3030/jsonstore/bus/schedule/';
    let stopID = 'depot';
    let infoBox = document.querySelector('.info');
    const departBtn = document.getElementById('depart');
    const arriveBtn = document.getElementById('arrive');


    async function depart() {
        try {
            departBtn.disabled = true;
            arriveBtn.disabled = false;
            let request = await fetch(`${baseURL}${stopID}`);
            let currentStop = await request.json();

            infoBox.textContent = `Next stop ${currentStop.name}`;
            stopID = currentStop.next;
        } catch (error) {
            departBtn.disabled = true;
            arriveBtn.disabled = true;
            infoBox.textContent = 'Error';
        }
    }

    function arrive() {
        arriveBtn.disabled = true;
        departBtn.disabled = false;
        let stopName = infoBox.textContent.split(' ').slice(2);
        infoBox.textContent = `Arriving at ${stopName.join(' ')}`;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();