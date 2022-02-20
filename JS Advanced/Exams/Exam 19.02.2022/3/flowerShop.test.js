const flowerShop = require('./flowerShop');
const { expect} = require('chai');

describe('flowerShop tests', () => {
    describe('calcPriceOfFlowers function tests', () => {
        it('should not work with wrong inputs', () => {
            expect(() => flowerShop.calcPriceOfFlowers('fl', '4', 5)).to.throw('Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers('fl', 4, '5')).to.throw('Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers([], 4, 5)).to.throw('Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers({}, 4.5, 5.5)).to.throw('Invalid input!');

        });

        it('should work properly', () => {
            expect(flowerShop.calcPriceOfFlowers('fl', 4, 5)).to.equal(`You need $20.00 to buy fl!`);
        });
    });

    describe('checkFlowersAvailable function tests', () => {
        it('should work properly', () => {
            expect(flowerShop.checkFlowersAvailable('Rose', ['Rose', 'Lily', 'Orchid'])).to.equal(`The Rose are available!`);
            expect(flowerShop.checkFlowersAvailable('Lily', ['Rose', 'Lily', 'Orchid'])).to.equal(`The Lily are available!`);
        });

        it('should not work properly', () => {
            expect(flowerShop.checkFlowersAvailable('fl', ['Rose', 'Lily', 'Orchid'])).to.equal(`The fl are sold! You need to purchase more!`);
        });
    });

    describe('sellFlowers function tests', () => {
        it('should not work with wrong input', () => {
            expect(() => flowerShop.sellFlowers({}, 4)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(null, 4)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(true, 4)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(undefined, 4)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers({}, 4)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], '4')).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], [])).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], {})).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], undefined)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], true)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], null)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], -1)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 4)).to.throw('Invalid input!');
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 3)).to.throw('Invalid input!');


        });

        it('should work properly', () => {
            expect(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 0)).to.equal('Lily / Orchid');
            expect(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 1)).to.equal('Rose / Orchid');
            expect(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 2)).to.equal('Rose / Lily');
        });
    });
});