function loadCommits() {
    let username = document.getElementById('username').value;
    let repository = document.getElementById('repo').value;
    let ulElement = document.getElementById('commits');

    let url = `https://api.github.com/repos/${username}/${repository}/commits`;

    fetch(url)
        .then(response => {
            if (response.ok === false) {
                throw new Error(response.status)
            }

            return response.json();
        })
        .then(responseHandler)
        .catch(errorHandler);

    function responseHandler(data) {
        ulElement.innerHTML = '';
        data.forEach(element => {
            let liElement = document.createElement('li');
            liElement.textContent = `${element.commit.author.name}: ${element.commit.message}`;
            ulElement.appendChild(liElement);
        });
    }

    function errorHandler(error){
        ulElement.innerHTML = '';
        let liElement = document.createElement('li');
        liElement.textContent = `Error: ${error.message} (Not Found)`
        ulElement.appendChild(liElement);
    }
}