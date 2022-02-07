function solve(arr, criteria) {

    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = Number(price);
            this.status = status;
        }

    }
    let result = [];
    arr.forEach(ticket => {
        let [destination, price, status] = ticket.split('|');
        let currentTicket = new Ticket(destination, price, status);
        result.push(currentTicket);
    });

    if (criteria === 'price') {
        result.sort((a,b) => a[criteria] - b[criteria]);
    } else{
        result.sort((a,b) => a[criteria].localeCompare(b[criteria]));
    }

    return result;

}


console.log(solve(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'destination'));