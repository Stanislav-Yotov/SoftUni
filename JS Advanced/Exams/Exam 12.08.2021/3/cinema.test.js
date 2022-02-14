const cinema = require('./cinema');
const { expect } = require('chai');
const { assert } = require('chai');

describe('cinema.tests', () => {
    describe('showMovies function', () => {
        it('should return message if no movies available', () => {
            expect(cinema.showMovies([])).to.equal('There are currently no movies to show.');
        });

        it('should work properly', () => {
            expect(cinema.showMovies(['Batman', 'Joker', 'The gentlemen'])).to.equal('Batman, Joker, The gentlemen');
        });
    });

    describe('ticketPrice function', () => {
        it('should work properly with various projection types', () => {
            expect(cinema.ticketPrice('Premiere')).to.equal(12.00);
        });

        it('should work properly with various projection types', () => {
            expect(cinema.ticketPrice('Normal')).to.equal(7.50);
        });

        it('should work properly with various projection types', () => {
            expect(cinema.ticketPrice('Discount')).to.equal(5.50);
        });

        it('should throw error if shedule is wrong', () => {
            expect(() => {cinema.ticketPrice('Wrong')}).to.throw('Invalid projection type.');
        });
    });

    describe('swapSeatsInHall function', () => {
        it('should throw error if first input is wrong', () => {
            expect(cinema.swapSeatsInHall('first', 5)).to.equal('Unsuccessful change of seats in the hall.');
            expect(cinema.swapSeatsInHall(-1, 5)).to.equal('Unsuccessful change of seats in the hall.');
            expect(cinema.swapSeatsInHall(0, 5)).to.equal('Unsuccessful change of seats in the hall.');
            expect(cinema.swapSeatsInHall(21, 5)).to.equal('Unsuccessful change of seats in the hall.');
        });

        it('should throw error if second input is wrong', () => {
            expect(cinema.swapSeatsInHall(4, 'five')).to.equal('Unsuccessful change of seats in the hall.');
            expect(cinema.swapSeatsInHall(4, -5)).to.equal('Unsuccessful change of seats in the hall.');
            expect(cinema.swapSeatsInHall(4, 0)).to.equal('Unsuccessful change of seats in the hall.');
            expect(cinema.swapSeatsInHall(4, 21)).to.equal('Unsuccessful change of seats in the hall.');
        });

        it('should work properly', () => {
            expect(cinema.swapSeatsInHall(4,5)).to.equal('Successful change of seats in the hall.');
            expect(cinema.swapSeatsInHall(1,20)).to.equal('Successful change of seats in the hall.');
        });
    });
});