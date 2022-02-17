const dealership = require('./dealership');
const { expect } = require('chai');

describe('dealership tests', () => {
    describe('newCarCost function tests', () => {
        it('should work without deduction of price', () => {
            expect(dealership.newCarCost('opel', 10000)).to.equal(10000);
        });

        it('should work with deduction of price', () => {
            expect(dealership.newCarCost('Audi A4 B8', 30000)).to.equal(15000);
        });
    });

    describe('carEquipment function tests', () => {
        it('should work properly', () => {
            let extras = ['e1', 'e2', 'e3', 'e4', 'e5', 'e6'];
            let indices = [2, 0, 1];
           expect(dealership.carEquipment(extras, indices)).to.deep.equal(['e3', 'e1', 'e2']);
           indices = [4, 3, 5];
           expect(dealership.carEquipment(extras, indices)).to.deep.equal(['e5', 'e4', 'e6']);
            
        });
    });

    describe('euroCategory function tests', () => {
        it('should be no discount', () => {
            expect(dealership.euroCategory(3)).to.equal('Your euro category is low, so there is no discount from the final price!');
        });

        it('should have discount', () => {
            expect(dealership.euroCategory(4)).to.equal(`We have added 5% discount to the final price: 14250.`);
        });
    });
});