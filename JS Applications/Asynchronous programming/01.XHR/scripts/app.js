function loadRepos() {
   let divElement = document.getElementById('res');
   let url = 'https://api.github.com/users/testnakov/repos';
   let XMLrequest = new XMLHttpRequest();
   XMLrequest.open("GET", url);

   XMLrequest.addEventListener('readystatechange', () => {
      if (XMLrequest.readyState === 4) {
         divElement.textContent = XMLrequest.responseText;
      }
   });

   XMLrequest.send();
}