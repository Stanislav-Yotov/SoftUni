function attachEvents() {
    const url = 'http://localhost:3030/jsonstore/phonebook';
    let loadBtn = document.getElementById('btnLoad');
    let createBtn = document.getElementById('btnCreate');
    let personInputField = document.getElementById('person');
    let phoneInputField = document.getElementById('phone');
    let phoneList = document.getElementById('phonebook');

    loadBtn.addEventListener('click', onLoad);
    createBtn.addEventListener('click', onCreate);

    async function onLoad(){
        phoneList.innerHTML = '';
        let request = await fetch(url);
        let data = await request.json();

        for (const [key, value] of Object.entries(data)) {
            let li = document.createElement('li');
            li.setAttribute('id', key);
            li.textContent = `${value.person}: ${value.phone}`;

            let deleteBtn = document.createElement('button');
            deleteBtn.textContent = 'Delete';

            deleteBtn.addEventListener('click', async () => {
                await fetch(`${url}/${li.id}`, {
                    method: 'delete',
                })
                loadBtn.click();
            })

            li.appendChild(deleteBtn);
            phoneList.appendChild(li);
        }
    };

    async function onCreate(){
        let person = personInputField.value;
        let phone = phoneInputField.value;
        personInputField.value = '';
        phoneInputField.value = '';

        await fetch(url, {
            method: 'post',
            headers: {
                'Content-type': 'application/json'
            },
            body: JSON.stringify({person, phone}),
        })
        loadBtn.click();
    }
}

attachEvents();