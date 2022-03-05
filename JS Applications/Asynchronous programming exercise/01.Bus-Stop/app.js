async function getInfo() {
    let stopId = document.getElementById('stopId').value;
    let timetable = document.getElementById('buses');
    let stopName = document.getElementById('stopName');
    let url = `http://localhost:3030/jsonstore/bus/businfo/${stopId}`;

    try {
        timetable.replaceChildren();
        let response = await fetch(url);
        let data = await response.json();
      
        stopName.textContent = data.name;
        Object.entries(data.buses).forEach(b => {
            let li = document.createElement('li');
            li.textContent = `Bus ${b[0]} arrives in ${b[1]} minutes`;
            timetable.appendChild(li);
        });
    } catch (error) {
        stopName.textContent = 'Error';
    }


}