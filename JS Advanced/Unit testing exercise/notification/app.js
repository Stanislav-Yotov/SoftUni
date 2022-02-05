function notify(message) {
  let contentElement = document.getElementById('content');
  contentElement.textContent = message;
  contentElement.style.display = 'block';

  contentElement.addEventListener('click', hide);

  function hide(e){
    e.target.style.display = 'none';
  }
}