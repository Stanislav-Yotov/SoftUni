window.addEventListener('load', solve);

function solve() {
    document.getElementById('add-btn').type = 'button';
    let genreInput = document.getElementById('genre');
    let nameInput = document.getElementById('name');
    let authorInput = document.getElementById('author');
    let dateInput = document.getElementById('date');

    let addBtn = document.getElementById('add-btn');
    addBtn.addEventListener('click', onClick);
    let counter = 0;

    function onClick() {
        if (genreInput != '' && nameInput != '' && authorInput != '' && dateInput != '') {

            let divHitsInfo = document.createElement('div');
            divHitsInfo.classList = 'hits-info';
            let img = document.createElement('img');
            img.src = './static/img/img.png';
            let headingGenres = document.createElement('h2');
            let headingNames = document.createElement('h2');
            let headingAuthors = document.createElement('h2');
            let headingDates = document.createElement('h3');

            let saveBtn = document.createElement('button');
            saveBtn.classList = 'save-btn';
            saveBtn.textContent = 'Save song';

            saveBtn.addEventListener('click', onSave);

            let likeBtn = document.createElement('button');
            likeBtn.classList = 'like-btn';
            likeBtn.textContent = 'Like song';

            likeBtn.addEventListener('click', onLike);

            let delBtn = document.createElement('button');
            delBtn.classList = 'delete-btn';
            delBtn.textContent = 'Delete';

            delBtn.addEventListener('click', onDelete);

            headingGenres.textContent = `Genre: ${genreInput.value}`;
            headingNames.textContent = `Name: ${nameInput.value}`;
            headingAuthors.textContent = `Author: ${authorInput.value}`;
            headingDates.textContent = `Date: ${dateInput.value}`;

            divHitsInfo.appendChild(img);
            divHitsInfo.appendChild(headingGenres);
            divHitsInfo.appendChild(headingNames);
            divHitsInfo.appendChild(headingAuthors);
            divHitsInfo.appendChild(headingDates);
            divHitsInfo.appendChild(saveBtn);
            divHitsInfo.appendChild(likeBtn);
            divHitsInfo.appendChild(delBtn);

            document.querySelector('.all-hits-container').appendChild(divHitsInfo);

            genreInput.value = '';
            nameInput.value = '';
            authorInput.value = '';
            dateInput.value = '';

            function onLike(e){
                counter++;
                document.querySelector(".likes").children[0].textContent = `Total Likes: ${counter}`;
                e.target.disabled = true;
            }

            function onSave(){
                document.querySelector(".saved-container").appendChild(divHitsInfo)
                divHitsInfo.removeChild(saveBtn)
 
                divHitsInfo.removeChild(likeBtn)
            }

            function onDelete(e){
                e.target.parentNode.parentNode.removeChild(divHitsInfo);
            }


        }

    }
}