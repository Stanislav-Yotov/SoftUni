function loadRepos() {
	let username = document.getElementById('username').value;
	let repos = document.getElementById('repos');

	fetch(`https://api.github.com/users/${username}/repos`)
	.then((result) => {
		if (result.ok === false) {
			throw new Error(result.status);
		}
		return result.json();
	})
	.then(handleResponse)
	.catch(error => {
		repos.textContent = `${error.message}`;
	});


	function handleResponse(res){
		repos.innerHTML = '';
		res.forEach(repo => {
			let liElement = document.createElement('li');
			let aElement = document.createElement('a');
			aElement.setAttribute('href', repo.html_url);
			aElement.textContent = repo.name;

			liElement.appendChild(aElement);
			repos.appendChild(liElement);
		});
	}
	
}