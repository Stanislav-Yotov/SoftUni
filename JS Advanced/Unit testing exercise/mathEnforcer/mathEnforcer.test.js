const mathEnforcer = require('./mathEnforcer');
const expect = require('chai').expect;

describe('mathEnforcer tests', () => {
    describe('addFive function', () => {
        it('should return undefined if the input is not a number', () => {
            let addFive = mathEnforcer.addFive;
            expect(addFive('five')).to.be.undefined;
            expect(addFive([])).to.be.undefined;
            expect(addFive(true)).to.be.undefined;
        });

        it('should work properly with numbers', () => {
            let addFive = mathEnforcer.addFive;
            expect(addFive(4)).to.equal(9);
            expect(addFive(4.5)).to.equal(9.5);
            expect(addFive(-4)).to.equal(1);
        });
    });

    describe('subtractTen function', () => {
        it('should return undefined if the input is not a number', () => {
            let subtractTen = mathEnforcer.subtractTen;
            expect(subtractTen('ten')).to.be.undefined;
            expect(subtractTen([])).to.be.undefined;
            expect(subtractTen(true)).to.be.undefined;
        });

        it('should work properly with numbers', () => {
            let subtractTen = mathEnforcer.subtractTen;
            expect(subtractTen(20)).to.equal(10);
            expect(subtractTen(20.5)).to.equal(10.5);
            expect(subtractTen(-20)).to.equal(-30);
        });
    });

    describe('sum function', () => {
        it('should return undefined if the input is not a number', () => {
            let sum = mathEnforcer.sum;
            expect(sum('4', 5)).to.be.undefined;
            expect(sum(4, true)).to.be.undefined;
        });

        it('should work properly with numbers', () => {
            let sum = mathEnforcer.sum;
            expect(sum(4, 5)).to.equal(9);
            expect(sum(4.5, 5.5)).to.equal(10);
            expect(sum(-4, -5)).to.equal(-9);


        });
    });
});