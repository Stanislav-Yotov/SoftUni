function solve() {
    let firstNameElement = document.getElementById('fname');
    let lastNameElement = document.getElementById('lname');
    let emailElement = document.getElementById('email');
    let dateOfBirthElement = document.getElementById('birth');
    let positionElement = document.getElementById('position');
    let salaryElement = document.getElementById('salary');
    let hireBtn = document.getElementById('add-worker');
    let tbody = document.getElementById('tbody');
    let budget = document.getElementById('sum');

    hireBtn.addEventListener('click', onHire);

    function onHire(e) {
        e.preventDefault();
        if (firstNameElement.value == '' || lastNameElement.value == '' || emailElement.value == ''
            || dateOfBirthElement.value == '' || positionElement.value == '' || salaryElement.value == '') {
            return;
        }

        let firstName = firstNameElement.value;
        let lastName = lastNameElement.value;
        let email = emailElement.value;
        let dateOfBirth = dateOfBirthElement.value;
        let position = positionElement.value;
        let salary = salaryElement.value;


        let trElement = document.createElement('tr');

        let tdFirstName = document.createElement('td');
        tdFirstName.textContent = firstName;
        let tdLastName = document.createElement('td');
        tdLastName.textContent = lastName;
        let tdEmail = document.createElement('td');
        tdEmail.textContent = email;
        let tdDateOfBirth = document.createElement('td');
        tdDateOfBirth.textContent = dateOfBirth;
        let tdPosition = document.createElement('td');
        tdPosition.textContent = position;
        let tdSalary = document.createElement('td');
        tdSalary.textContent = salary;
        let tdButtons = document.createElement('td');
        let fireBtn = document.createElement('button');
        fireBtn.classList.add('fired');
        fireBtn.textContent = 'Fired';
        fireBtn.addEventListener('click', onFire);
        let editBtn = document.createElement('button');
        editBtn.classList.add('edit');
        editBtn.textContent = 'Edit';
        editBtn.addEventListener('click', onEdit);

        tdButtons.appendChild(fireBtn);
        tdButtons.appendChild(editBtn);

        trElement.appendChild(tdFirstName);
        trElement.appendChild(tdLastName);
        trElement.appendChild(tdEmail);
        trElement.appendChild(tdDateOfBirth);
        trElement.appendChild(tdPosition);
        trElement.appendChild(tdSalary);
        trElement.appendChild(tdButtons);
        tbody.appendChild(trElement);

        firstNameElement.value = '';
        lastNameElement.value = '';
        emailElement.value = '';
        dateOfBirthElement.value = '';
        positionElement.value = '';
        salaryElement.value = '';

        let budgetMoney = Number(budget.textContent);
        let totalPrice = budgetMoney + Number(salary);
        budget.textContent = totalPrice.toFixed(2);

        function onEdit() {
            while (trElement.firstChild) {
                trElement.removeChild(trElement.firstChild)
            }
            firstNameElement.value = firstName;
            lastNameElement.value = lastName;
            emailElement.value = email;
            dateOfBirthElement.value = dateOfBirth;
            positionElement.value = position;
            salaryElement.value = salary;

            budgetMoney = Number(budget.textContent);
            totalPrice = budgetMoney - Number(salary);
            budget.textContent = totalPrice.toFixed(2);
        }

        function onFire(){
            while (trElement.firstChild) {
                trElement.removeChild(trElement.firstChild)
            }

            budgetMoney = Number(budget.textContent);
            totalPrice = budgetMoney - Number(salary);
            budget.textContent = totalPrice.toFixed(2);
        }


    }
}
solve()