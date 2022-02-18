const companyAdministration = require('./companyAdministration');
const { expect } = require('chai');

describe('companyAdministration tests', () => {
    describe('hiringEmployee function tests', () => {
        it('should throw error if position string is different from Programmer', () => {
            expect(() => {companyAdministration.hiringEmployee('Stancho', 'Janitor', 3)})
            .to.throw('We are not looking for workers for this position.')
        });

        it('should be hired', () => {
            expect(companyAdministration.hiringEmployee('Stancho', 'Programmer', 3))
            .to.equal('Stancho was successfully hired for the position Programmer.');
            expect(companyAdministration.hiringEmployee('Stancho', 'Programmer', 4))
            .to.equal('Stancho was successfully hired for the position Programmer.');
        });

        it('should not be hired', () => {
            expect(companyAdministration.hiringEmployee('Stancho', 'Programmer', 2.5))
            .to.equal('Stancho is not approved for this position.');
            expect(companyAdministration.hiringEmployee('Stancho', 'Programmer', 2))
            .to.equal('Stancho is not approved for this position.');
        });
    });

    describe('calculateSalary function tests', () => {
        it('should throw error if the input is not a number', () => {
            expect(() => companyAdministration.calculateSalary('10')).to.throw('Invalid hours');
            expect(() => companyAdministration.calculateSalary([])).to.throw('Invalid hours');
            expect(() => companyAdministration.calculateSalary({})).to.throw('Invalid hours');
            expect(() => companyAdministration.calculateSalary(true)).to.throw('Invalid hours');
            expect(() => companyAdministration.calculateSalary(null)).to.throw('Invalid hours');
            expect(() => companyAdministration.calculateSalary(-2)).to.throw('Invalid hours');
        });

        it('should work corectly without bonus', () => {
            expect(companyAdministration.calculateSalary(100)).to.equal(1500);
            expect(companyAdministration.calculateSalary(160)).to.equal(2400);
        });

        it('should work corectly with bonus', () => {
            expect(companyAdministration.calculateSalary(170)).to.equal(3550);
        });
    });

    describe('firedEmployee function tests', () => {
        it('should throw error if the input is wrong', () => {
            expect(() => companyAdministration.firedEmployee([], 2)).to.throw('Invalid input');
            expect(() => companyAdministration.firedEmployee({}, 2)).to.throw('Invalid input');
            expect(() => companyAdministration.firedEmployee(true, 2)).to.throw('Invalid input');
            expect(() => companyAdministration.firedEmployee(null, 2)).to.throw('Invalid input');
            expect(() => companyAdministration.firedEmployee(undefined, 2)).to.throw('Invalid input');
            expect(() => companyAdministration.firedEmployee(5, 2)).to.throw('Invalid input');
            expect(() => companyAdministration.firedEmployee(['gosho', 'pesho', 'ivan'], -1)).to.throw('Invalid input');
            expect(() => companyAdministration.firedEmployee(['gosho', 'pesho', 'ivan'], 3)).to.throw('Invalid input');
            expect(() => companyAdministration.firedEmployee(['gosho', 'pesho', 'ivan'], '2')).to.throw('Invalid input');
        });

        it('should work corectly', () => {
            expect(companyAdministration.firedEmployee(['gosho', 'pesho', 'ivan'], 1)).to.equal('gosho, ivan');
        });
    });
});