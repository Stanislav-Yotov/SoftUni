const testNumbers = require('./testNumbers');
const { expect } = require('chai');

describe('testNumbers tests', () => {
    describe('sumNumbers function', () => {
        it('should work properly with numbers', () => {
            expect(testNumbers.sumNumbers(3,2)).to.equal('5.00');
            expect(testNumbers.sumNumbers(-3,-2)).to.equal('-5.00');
        });

        it('should not work with other output', () => {
            expect(testNumbers.sumNumbers('2',3)).to.be.undefined;
            expect(testNumbers.sumNumbers(2,'3')).to.be.undefined;
            expect(testNumbers.sumNumbers([],3)).to.be.undefined;
            expect(testNumbers.sumNumbers({},3)).to.be.undefined;
            expect(testNumbers.sumNumbers(null,3)).to.be.undefined;
            expect(testNumbers.sumNumbers(true,3)).to.be.undefined;
        });
    });

    describe('numberChecker function', () => {
        it('should throw error if NaN', () => {
            expect(() => { testNumbers.numberChecker(NaN) }).to.throw('The input is not a number!');
        });

        it('should work with even numbers', () => {
            expect(testNumbers.numberChecker(4)).to.equal('The number is even!');
            expect(testNumbers.numberChecker('4')).to.equal('The number is even!');

        });

        it('should work with odd numbers', () => {
            expect(testNumbers.numberChecker(5)).to.equal('The number is odd!');
            expect(testNumbers.numberChecker('5')).to.equal('The number is odd!');

        });
    });

    describe('averageSumArray function', () => {
        it('should work properly', () => {
            expect(testNumbers.averageSumArray([4,3,5])).to.equal(4);
        });
    });
});