class Company{
    constructor(){
        this.departments = {};
    }

    addEmployee(name, salary, position, department){
        if (isEmptyUndefinedOrNull(name) 
        || isEmptyUndefinedOrNull(salary)
        || Number(salary) < 0
        || isEmptyUndefinedOrNull(position)
        || isEmptyUndefinedOrNull(department)) {
            throw new Error('Invalid input');
        }

        if (!this.departments[department]) {
            this.departments[department] = {};
            this.departments[department].employees = [];
        }

        let employee = Object.assign({
            name,
            salary: Number(salary),
            position
        });

        this.departments[department].employees.unshift(employee);

        return `New employee is hired. Name: ${name}. Position: ${position}`;

        function isEmptyUndefinedOrNull(param){
            if (param === '' || param === null || param === undefined){
                return true;
            }
            return false;
        }
    }

    bestDepartment(){
        let bestDepartmentSalary = 0;
        let bestDepartmentName;
        let bestDepartment;

        for (const department in this.departments) {
            this.departments[department].averageSalary = this.departments[department].employees.reduce((a,b) => a + b, 0) 
            / this.departments[department].employees.length;

            if (this.departments[department].averageSalary > bestDepartmentSalary) {
                bestDepartmentSalary = this.departments[department].averageSalary;
                bestDepartment = this.departments[department];
                bestDepartmentName = department;
            }
        }

        bestDepartment.employees.sort((a,b) => a.salary - b.salary || a['name'].localeCompare(b['name']));

        return `Best Department is: ${bestDepartmentName}\n
        Average salary: ${bestDepartmentSalary.toFixed(2)}\n
        ${bestDepartment.employees.map(e => `${e.name} ${e.salary} ${e.position}`).join('\n')}`;

    }
}

let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());
