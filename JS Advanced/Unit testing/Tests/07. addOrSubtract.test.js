const createCalculator = require('./07. addOrSubtract');
const {assert} = require('chai');

describe('Add / Subtract tests', () => {
    it('should return object with add, subtract and get functions', () => {
        let obj = createCalculator();
        assert.isFunction(obj.add);
        assert.isFunction(obj.subtract);
        assert.isFunction(obj.get);
    });

    it('should return object', () => {
        let obj = createCalculator();
        let type = typeof obj;
        assert.equal('object', type);
    });

    it('should work properly', () => {
        let obj = createCalculator();
        obj.add(10);
        obj.subtract(5);
        let result = obj.get();
        assert.equal(result, 5);
    });

    it('should work with string numbers', () => {
        let obj = createCalculator();
        obj.add('4');
        obj.add('5');
        let result = obj.get();
        assert.equal(result, 9);
    });

    it('should return NaN when input is string', () => {
        let obj = createCalculator();
        obj.add('djkbfj');
        let result = obj.get();
        assert.isNaN(result);
    });
});