window.addEventListener('load', solve);

function solve() {
    let typeElement = document.getElementById('type-product');
    let descriptionElement = document.getElementById('description');
    let clientNameElement = document.getElementById('client-name');
    let clientPhoneElement = document.getElementById('client-phone');
    let submitBtn = document.getElementsByTagName('button')[0];
    let receivedOrdersSection = document.getElementById('received-orders');
    let completedOrdersSection = document.getElementById('completed-orders');
    let clearBtn = document.querySelector('.clear-btn');
    

    submitBtn.addEventListener('click', submitOrder);

    function submitOrder(e) {
        e.preventDefault();
        if (descriptionElement.value == '' || clientNameElement.value == '' || clientPhoneElement.value == '') {
            return;
        }

        let type = typeElement.value;
        let description = descriptionElement.value;
        let clientName = clientNameElement.value;
        let clientPhone = clientPhoneElement.value;

        let divElement = document.createElement('div');
        divElement.classList.add('container');

        let h2Element = document.createElement('h2');
        h2Element.textContent = `Product type for repair: ${type}`;
        let h3Element = document.createElement('h3');
        h3Element.textContent = `Client information: ${clientName}, ${clientPhone}`;
        let h4Element = document.createElement('h4');
        h4Element.textContent = `Description of the problem: ${description}`;
        let startBtn = document.createElement('button');
        startBtn.classList.add('start-btn');
        startBtn.textContent = 'Start repair';
        startBtn.addEventListener('click', onStart);
        let finishBtn = document.createElement('button');
        finishBtn.classList.add('finish-btn');
        finishBtn.addEventListener('click', onFinish);
        finishBtn.textContent = 'Finish repair';

        divElement.appendChild(h2Element);
        divElement.appendChild(h3Element);
        divElement.appendChild(h4Element);
        divElement.appendChild(startBtn);
        divElement.appendChild(finishBtn);

        receivedOrdersSection.appendChild(divElement);

        typeElement.value = '';
        descriptionElement.value = '';
        clientNameElement.value = '';
        clientPhoneElement.value = '';

        finishBtn.disabled = true;

        clearBtn.addEventListener('click', onClear);

        function onStart(){
            startBtn.disabled = true;
            finishBtn.disabled = false;
        }

        function onFinish(){
            let buttons = divElement.querySelectorAll('button');
            buttons[0].remove();
            buttons[1].remove();

            completedOrdersSection.appendChild(divElement);
        }

        function onClear(){
            let elementToClear = Array.from(completedOrdersSection.querySelectorAll('div'));
            elementToClear.forEach(e => {
                e.remove();
            });
        }

    }
}