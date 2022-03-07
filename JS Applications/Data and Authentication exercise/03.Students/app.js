async function solve(){
    const url = 'http://localhost:3030/jsonstore/collections/students';
    const table = document.querySelector('#results tbody');

    const response = await fetch(url);
    const data = await response.json();

    Object.values(data).forEach(s => {
        let firstName = s.firstName;
        let lastName = s.lastName;
        let facultyNumber = s.facultyNumber;
        let grade = Number(s.grade);

        let tr = document.createElement('tr');
        let firstNameCell = tr.insertCell(0);
        firstNameCell.textContent = firstName;

        let lastNameCell = tr.insertCell(1);
        lastNameCell.textContent = lastName;

        let facultyNumberCell = tr.insertCell(2);
        facultyNumberCell.textContent = facultyNumber;

        let gradeCell = tr.insertCell(3);
        gradeCell.textContent = grade;

        table.appendChild(tr);
        
    });

    const submitBtn = document.getElementById('submit');
    submitBtn.addEventListener('click', onSubmit);
    async function onSubmit(e){
        //e.preventDefault();

        let firstNameInput = document.getElementsByName('firstName')[0];
        let lastNameInput = document.getElementsByName('lastName')[0];
        let facultyNumberInput = document.getElementsByName('facultyNumber')[0];
        let gradeInput = document.getElementsByName('grade')[0];

        if (!firstNameInput.value || !lastNameInput.value || !facultyNumberInput.value
            || !gradeInput.value) {
            alert('You must fill all fields!');
            return;
        }

        if (isNaN(gradeInput.value)) {
            alert('Grade must be a number!');
            return;
        }

        const response = await fetch(url, {
            method: 'post',
            headers: {'Content-type':'application/json'},
            body: JSON.stringify({
                firstName: firstNameInput.value,
                lastName: lastNameInput.value,
                facultyNumber: facultyNumberInput.value,
                grade: Number(gradeInput.value),
            })
        });

        firstNameInput.value = '';
        lastNameInput.value = '';
        facultyNumberInput.value = '';
        gradeInput.value = '';
    }
}

solve();