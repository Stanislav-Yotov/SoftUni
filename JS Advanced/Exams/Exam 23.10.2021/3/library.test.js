const library = require('./library');
const { assert } = require('chai');
const { expect } = require('chai');

describe('Library tests', () => {
    describe('calcPriceOfBook tests', () => {
        it('should throw error if first argument is wrong', () => {
            expect(() => { library.calcPriceOfBook(12, 1981) }).to.throw('Invalid input');
            expect(() => { library.calcPriceOfBook([], 1981) }).to.throw('Invalid input');
            expect(() => { library.calcPriceOfBook(null, 1981) }).to.throw('Invalid input');
            expect(() => { library.calcPriceOfBook(undefined, 1981) }).to.throw('Invalid input');
        });

        it('should throw error if second argument i wrong', () => {
            expect(() => { library.calcPriceOfBook('Pirates die young', '1981') }).to.throw('Invalid input');
            expect(() => { library.calcPriceOfBook('Pirates die young', []) }).to.throw('Invalid input');
            expect(() => { library.calcPriceOfBook('Pirates die young', null) }).to.throw('Invalid input');
            expect(() => { library.calcPriceOfBook('Pirates die young', undefined) }).to.throw('Invalid input');
        });

        it('should work properly below 1980', () => {
            expect(library.calcPriceOfBook('Pirates die young', 1979)).to.equal('Price of Pirates die young is 10.00');
            expect(library.calcPriceOfBook('Pirates die young', 1980)).to.equal('Price of Pirates die young is 10.00');
        });

        it('should work properly above 1980', () => {
            expect(library.calcPriceOfBook('Pirates die young', 1981)).to.equal('Price of Pirates die young is 20.00');
        });
    });

    describe('findBook tests', () => {
        it('should throw error if there are no books', () => {
            expect(() => {library.findBook([], 'Pirates die young')}).to.throw('No books currently available');
        });

        it('should return desired book if available', () => {
            expect(library.findBook(['Pirates die young', '1984', 'War and peace'], 'Pirates die young'))
            .to.equal('We found the book you want.');
        });

        it('should throw error if desired book is not available', () => {
            expect(() => {library.findBook(['Lord of the rings', '1984', 'War and peace'], 'Pirates die young')
            .to.throw('The book you are looking for is not here!')});
        });
    });

    describe('arrangeTheBooks tests', () => {
        it('should throw error if the input is invalid', () => {
            expect(() => { library.arrangeTheBooks('1')}).to.throw('Invalid input');
            expect(() => { library.arrangeTheBooks(-1)}).to.throw('Invalid input');
        });

        it('should work properly', () => {
            expect(library.arrangeTheBooks(20)).to.equal('Great job, the books are arranged.');
            expect(library.arrangeTheBooks(40)).to.equal('Great job, the books are arranged.');
        });

        it('should return capacity full message', () => {
            expect(library.arrangeTheBooks(41)).to.equal('Insufficient space, more shelves need to be purchased.');
        });
    });
});