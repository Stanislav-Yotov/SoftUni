function addItem() {
    let inputElement = document.getElementById('newItemText');
    let input = inputElement.value;
    inputElement.value = '';
    let list = document.getElementById('items');
    
    let li = document.createElement('li');
    li.textContent = input;

    let aAtribute = document.createElement('a');
    aAtribute.textContent = '[Delete]';
    aAtribute.href = '#';
    
    li.appendChild(aAtribute);
    list.appendChild(li);
    aAtribute.addEventListener('click', removeItem);

    function removeItem(item) {
        item.currentTarget.parentNode.remove();
      }
}