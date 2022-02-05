const lookupChar = require('./charLookup');
const { expect } = require('chai');

describe('charLookup tests', () => {
    it('should return undefined if the first parameter is not string', () => {
        expect(lookupChar(3, 4)).to.be.undefined;
        expect(lookupChar(3.5, 4)).to.be.undefined;
        expect(lookupChar([], 4)).to.be.undefined;
    });

    it('should return undefined if the second parameter is not a number', () => {
        expect(lookupChar('sss', 'aaa')).to.be.undefined;
        expect(lookupChar('sss', 3.4)).to.be.undefined;
        expect(lookupChar('sss', [])).to.be.undefined;
    });

    it('should return undefined when both parameters are incorect', () => {
        expect(lookupChar(2,'sss')).to.be.undefined;
    });

    it('should return Incorrect index, if the index is not correct', () => {
        expect(lookupChar('sss', 4)).to.equal('Incorrect index');
        expect(lookupChar('sss', -1)).to.equal('Incorrect index')
    });

    it('should work properly', () => {
        expect(lookupChar('ssts', 2)).to.equal('t');
    });
}); 