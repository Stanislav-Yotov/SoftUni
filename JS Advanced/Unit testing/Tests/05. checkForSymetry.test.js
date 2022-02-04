const isSymmetric = require('./05. checkForSymetry');
const { assert } = require('chai');

describe('Check for symetry tests', () => {
    it('should return true if the array is symetric', () => {
        let symArr = [2, 3, 3, 2];
        assert.isTrue(isSymmetric(symArr));
    });

    it('should return false if the array is not symetric', () => {
        let arr = [12, 2, 8];
        assert.isFalse(isSymmetric(arr));
    });
    
    it('should return false when input is not array', () => {
        let input = 'wazaaa';
        let input1 = 12;
        let input2 = undefined;
        assert.isFalse(isSymmetric(input));
        assert.isFalse(isSymmetric(input1));
        assert.isFalse(isSymmetric(input2));
    });

    it('should return true when the input is array', () => {
        let input = [1, 2, 3];
        assert.isArray(input);
    });

    it('should return true when the array is other than numeric', () => {
        let word = ['eye'];
        assert.isTrue(isSymmetric(word));
    });

    it('should return false if array is symetric, but with different data types', () => {
        let arr = [2, 3, 3, '2'];
        assert.isFalse(isSymmetric(arr));
    })


});