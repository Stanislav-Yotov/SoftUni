const rgbToHexColor = require('../06. rgbToHex');
const {assert} = require('chai');

describe('RGB to HEX color tests', () =>{
    it('should return undefined when red is not valid', () => {
        assert.equal(rgbToHexColor(-2, 5, 18), undefined);
        assert.equal(rgbToHexColor('a', 5, 18), undefined);
        assert.equal(rgbToHexColor(null, 5, 18), undefined);
        assert.equal(rgbToHexColor(2.5, 5, 18), undefined);
        assert.equal(rgbToHexColor(257, 5, 18), undefined);
    });

    it('should return undefined when green is not valid', () => {
        assert.equal(rgbToHexColor(2, -5, 18), undefined);
        assert.equal(rgbToHexColor(2, 'a', 18), undefined);
        assert.equal(rgbToHexColor(2, null, 18), undefined);
        assert.equal(rgbToHexColor(2, 5.5, 18), undefined);
        assert.equal(rgbToHexColor(2, 257, 18), undefined);
    });

    it('should return undefined when blue is not valid', () => {
        assert.equal(rgbToHexColor(2, 5, -18), undefined);
        assert.equal(rgbToHexColor(2, 5, 'a'), undefined);
        assert.equal(rgbToHexColor(2, 5, null), undefined);
        assert.equal(rgbToHexColor(2, 5, 18.5), undefined);
        assert.equal(rgbToHexColor(2, 5, 257), undefined);
    });

    it('should work properly when correct input is given', () => {
        let expected = '#FF9EAA';
        assert.equal(rgbToHexColor(255, 158, 170), expected);
    });

    it('should work properly when on upper limit', () =>{
        let expected = '#FFFFFF';
        assert.equal(rgbToHexColor(255, 255, 255), expected);
    });

    it('should work properly when on lower limit', () =>{
        let expected = '#000000';
        assert.equal(rgbToHexColor(0, 0, 0), expected);
    });
});