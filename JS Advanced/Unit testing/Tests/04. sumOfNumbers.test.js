const sum = require('../04. sumOfNumbers');
const assert = require('chai').assert;
const { expect} = require('chai');

describe('Sum of numbers tests', () => {
    it('should sum numbers of the array', () => {
        let arr = [10, 20, 30];
        let expected = 60;
        assert.equal(sum(arr), expected);
    });

    it('should work properly when given empty array', () => {
        let arr = [];
        assert.equal(sum(arr), 0)
    });

    it('should throw error if argument is nto a number', () => {
        let arr = [2, 'six', 7];
        assert.isNaN(sum(arr));
    });

    it('should work properly with negative numbers', () => {
        let arr = [1,2,3,4,-2];
        let expected = 8;
        assert.equal(sum(arr), expected)
    });
});