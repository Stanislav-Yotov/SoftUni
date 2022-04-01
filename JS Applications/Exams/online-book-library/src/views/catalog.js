import { html, nothing } from '../../node_modules/lit-html/lit-html.js';
import * as booksService from '../api/books.js';

const catalogTemplate = (books) => html`
<section id="my-books-page" class="my-books">
    <h1>My Books</h1>
    <ul class="my-books-list">
        ${books.map(bookTemplate)}
        ${books.length == 0
           ? html`<p class="no-books">No books in database!</p>` 
           : nothing
         }
    </ul>   
</section>`;

const bookTemplate = (book) => html`
<li class="otherBooks">
    <h3>${book.title}</h3>
    <p>Type: ${book.type}</p>
    <p class="img"><img src=${book.imageUrl}></p>
    <a class="button" href="/details/${book._id}">Details</a>
</li>`;

export async function catalogPage(ctx) {
    const user = JSON.parse(localStorage.getItem('user'));
   
    const books = await booksService.getByUserId(user._id)
    
    ctx.render(catalogTemplate(books));
}