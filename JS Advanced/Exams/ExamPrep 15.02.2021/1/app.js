function solution() {
    let input = document.querySelector('input[type="text"]');
    let addBtn = document.getElementsByTagName('button')[0];
    let [add, list, sent, discarded] = document.querySelectorAll('.card');

    addBtn.addEventListener('click', addGift);

    function addGift() {
        if (input.value) {
            let ul = list.querySelector('ul');
            let li = document.createElement('li');
            li.classList.add('gift');
            li.textContent = input.value;

            let sendBtn = document.createElement('button');
            sendBtn.textContent = 'Send';
            sendBtn.setAttribute('id', 'sendButton');
            sendBtn.addEventListener('click', onSend);
            let discardBtn = document.createElement('button');
            discardBtn.textContent = 'Discard';
            discardBtn.setAttribute('id', 'discardButton');
            discardBtn.addEventListener('click', onDelete);

            li.appendChild(sendBtn);
            li.appendChild(discardBtn);
            ul.appendChild(li);

            Array.from(ul.querySelectorAll('li'))
                .sort((a, b) => { return a.textContent.localeCompare(b.textContent) })
                .map(li => ul.appendChild(li));
        }
        input.value = '';
    }

    function onSend(e) {
        let currentElement = e.target.parentElement;
        sent.querySelector('ul').appendChild(currentElement);
        Array.from(currentElement.querySelectorAll('button'))
             .map((btn) => {btn.remove();
            });
    }

    function onDelete(e){
        let currentElement = e.target.parentElement;
        discarded.querySelector('ul').appendChild(currentElement);
        Array.from(currentElement.querySelectorAll('button'))
             .map((btn) => {btn.remove();
            });
    }
}