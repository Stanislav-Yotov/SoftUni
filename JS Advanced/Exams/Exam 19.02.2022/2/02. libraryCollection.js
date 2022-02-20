class LibraryCollection {
    constructor(capacity) {
        this.capacity = Number(capacity);
        this.books = [];
    }

    addBook(bookName, bookAuthor) {
        let book = {
            bookName,
            bookAuthor,
            payed: false,
        };

        if (this.capacity <= this.books.length) {
            throw new Error('Not enough space in the collection.');
        } else {
            this.books.push(book);
            return `The ${bookName}, with an author ${bookAuthor}, collect.`;
        }
    };

    payBook(bookName) {
        let currentBook = this.books.find(x => x.bookName === bookName);
        if (!currentBook) {
            throw new Error(`${bookName} is not in the collection.`)
        } else if (currentBook['payed'] == true) {
            throw new Error(`${bookName} has already been paid`);
        } else {
            currentBook['payed'] = true;
            return `${bookName} has been successfully paid.`;
        }
    };

    removeBook(bookName){
        let currentBook = this.books.find(x => x.bookName === bookName);
        if (!currentBook) {
            throw new Error(`The book, you're looking for, is not found.`);
        }

        if (currentBook['payed'] == false) {
            throw new Error(`${bookName} need to be paid before removing from the collection.`);
        }

        this.books.pop(currentBook);
        return `${bookName} remove from the collection.`;

    }; 

    getStatistics(bookAuthor){
        if(!bookAuthor){
            let result = [];
            let emptySlots = this.capacity - this.books.length;
            result.push(`The book collection has ${emptySlots} empty spots left.`)
            this.books.sort((a,b) => a.bookName.localeCompare(b.bookName)).forEach(x => {
                result.push(`${x.bookName} == ${x.bookAuthor} - ${x.payed ? 'Has Paid' : 'Not Paid'}.`)
            });
            return result.join('\n');
        }

        if (!this.books.some(x => x.bookAuthor == bookAuthor)) {
            throw new Error(`${bookAuthor} is not in the collection.`)
        }

        let result = [];
           this.books.sort(x => x.bookAuthor == bookAuthor).forEach(a => {
               result.push(`${a.bookName} == ${a.bookAuthor} - ${a.payed ? 'Has Paid' : 'Not Paid'}.`) 
           });
           return result.join('\n');
        
    };
}

/*const library = new LibraryCollection(2)
console.log(library.addBook('In Search of Lost Time', 'Marcel Proust'));
console.log(library.addBook('Don Quixote', 'Miguel de Cervantes'));
console.log(library.addBook('Ulysses', 'James Joyce'));*/

/*const library = new LibraryCollection(2)
library.addBook('In Search of Lost Time', 'Marcel Proust');
console.log(library.payBook('In Search of Lost Time'));
console.log(library.payBook('Don Quixote'));*/

/*const library = new LibraryCollection(2)
library.addBook('In Search of Lost Time', 'Marcel Proust');
library.addBook('Don Quixote', 'Miguel de Cervantes');
library.payBook('Don Quixote');
console.log(library.removeBook('Don Quixote'));
console.log(library.removeBook('In Search of Lost Time'));*/

/*const library = new LibraryCollection(2)
console.log(library.addBook('Don Quixote', 'Miguel de Cervantes'));
console.log(library.getStatistics('Miguel de Cervantes'));
console.log(library.getStatistics('Stancho'));*/


/*const library = new LibraryCollection(5)
library.addBook('Don Quixote', 'Miguel de Cervantes');
library.payBook('Don Quixote');
library.addBook('In Search of Lost Time', 'Marcel Proust');
library.addBook('Ulysses', 'James Joyce');
console.log(library.getStatistics());*/


let str = 'hello';
console.log(str.length);



