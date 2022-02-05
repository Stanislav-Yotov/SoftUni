const isOddOrEven = require('./evenOrOdd');
const { assert } = require('chai');
const { expect } = require('chai');


describe('evenOrOdd tests', () => {
    it('should not work with different than string type', () => {
        expect(isOddOrEven(12)).to.be.undefined;
        expect(isOddOrEven(true)).to.be.undefined;
        expect(isOddOrEven([])).to.be.undefined;
        expect(isOddOrEven({})).to.be.undefined;
    });

    it('should work when even', () => {
        expect(isOddOrEven('string')).to.equal('even');
    });

    it('should work when even', () => {
        expect(isOddOrEven('strin')).to.equal('odd');
    });
});