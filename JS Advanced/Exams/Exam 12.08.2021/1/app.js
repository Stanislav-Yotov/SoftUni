window.addEventListener('load', solve);

function solve() {
    let modelElement = document.getElementById('model');
    let yearElement = document.getElementById('year');
    let descriptionElement = document.getElementById('description');
    let priceElement = document.getElementById('price');

    let addBtn = document.getElementById('add');

    let tbody = document.getElementById('furniture-list');

    addBtn.addEventListener('click', addFurniture);

    function addFurniture(e) {
        e.preventDefault();

        let yearNum = Number(yearElement.value);
        let priceNum = Number(priceElement.value).toFixed(2);

        if (modelElement.value && descriptionElement.value && yearNum > 0 && priceNum > 0) {
            let trFirst = document.createElement('tr');
            trFirst.className = 'info';
            let img = document.createElement('img');
            img.src = './images/img.jpg';

            let tdModel = document.createElement('td');
            tdModel.textContent = modelElement.value;
            trFirst.appendChild(tdModel);

            let tdPrice = document.createElement('td');
            tdPrice.textContent = `${priceNum}`;
            trFirst.appendChild(tdPrice);

            let btnTd = document.createElement('td');
            let moreBtn = document.createElement('button');
            moreBtn.className = 'moreBtn';
            moreBtn.textContent = 'More Info';
            btnTd.appendChild(moreBtn);

            let buyBtn = document.createElement('button');
            buyBtn.className = 'buyBtn';
            buyBtn.textContent = 'Buy it';
            btnTd.appendChild(buyBtn);

            trFirst.appendChild(btnTd);

            tbody.appendChild(trFirst);

            let trHide = document.createElement('tr');
            trHide.className = 'hide';
            let tdYear = document.createElement('td');
            tdYear.textContent = `Year: ${yearNum}`;
            trHide.appendChild(tdYear);

            let tdDescription = document.createElement('td');
            tdDescription.setAttribute('colspan', '3');
            tdDescription.textContent = `Description: ${descriptionElement.value}`;
            trHide.appendChild(tdDescription);

            tbody.appendChild(trHide);

            modelElement.value = '';
            yearElement.value = '';
            descriptionElement.value = '';
            priceElement.value = '';
        }
    }

    tbody.addEventListener('click', onClick);

    function onClick(e) {
        e.preventDefault();

        if (e.target.textContent == 'More Info') {
            let tbodyElement = e.target.parentElement.parentElement.parentElement;
            tbodyElement.lastChild.style.display = 'contents';
        } else if (eventTarget.textContent == 'Less Info') {
            let tbodyElement = e.target.parentElement.parentElement.parentElement;
            tbodyElement.lastChild.style.display = '';
            eventTarget.textContent = 'More Info';
        } else {
            let tdTotalPrice = document.querySelector('.total-price');
 
            let curSum = Number(tdTotalPrice.textContent);
 
            let currPrice = (eventTarget.parentElement.parentElement.children[1]);
 
            let sumChear = Number(currPrice.textContent);
 
 
            tdTotalPrice.textContent = Number(sumChear + curSum).toFixed(2);
 
            e.target.parentElement.parentElement.remove()
        }
    }

}
