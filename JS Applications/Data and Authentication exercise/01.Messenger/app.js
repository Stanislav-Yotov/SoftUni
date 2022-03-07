function attachEvents() {
    const messages = document.getElementById('messages');
    const url = 'http://localhost:3030/jsonstore/messenger';
    let sendBtn = document.getElementById('submit');
    let refreshBtn = document.getElementById('refresh');
    let authorInput = document.querySelector('[name="author"]');
    let messageInput = document.querySelector('[name="content"]');

    sendBtn.addEventListener('click', onSubmit);

    async function onSubmit() {
        let author = authorInput.value;
        let message = messageInput.value;
        authorInput.value = '';
        messageInput.value = '';

        let post = {
            author,
            content: message,
        }

        await fetch(url, {
            method: 'post',
            headers: {
                'Content-type': 'application/json'
            },
            body: JSON.stringify(post)
        });
    }

    refreshBtn.addEventListener('click', onRefresh);

    async function onRefresh() {
        let request = await fetch(url);
        let data = await request.json();

        for (const [, value] of Object.entries(data)) {
            messages.textContent += `${value.author}: ${value.content}\n`;
        }
    }
}

attachEvents();