function printdeckOfCards(input) {
    
    function createCard(face, suit) {
        let faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
        let suits = {
            S: '\u2660 ',
            H: '\u2665 ',
            D: '\u2666 ',
            C: '\u2663 '
        };

        face = face.toUpperCase();
        if (!faces.includes(face)) {
            throw new Error(`Invalid card: ${face}${suit}`);
        }

        if (!suits.hasOwnProperty(suit)) {
            throw new Error(`Invalid card: ${face}${suit}`);
        }

        let card = {
            face,
            suit: suits[suit],
            toString() {
                return this.face + this.suit;
            }

        };

        return card.toString();
    }

    let printingArr;
    try {
        printingArr = input.map(x => {
            let face = x.slice(0, x.length - 1);
            let suit = x[x.length - 1];
            return createCard.apply(x, [face, suit]);
        });

    } catch (ex) {
        console.log(ex.message);
        return;
    }

    console.log(printingArr.join(' '));
}

//console.log(printdeckOfCards(['AS', '10D', 'KH', '2C']));
//console.log(printdeckOfCards(['5S', '3D', 'QD', '1C']));