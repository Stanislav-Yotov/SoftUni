import { html, nothing } from '../../node_modules/lit-html/lit-html.js';
import * as booksService from '../api/books.js';


const detailsTemplate = (book, onDelete, user) => html`
<section id="details-page" class="details">
    <div class="book-information">
        <h3>${book.title}</h3>
        <p class="type">Type: ${book.type}</p>
        <p class="img"><img src=${book.imageUrl}></p>
        <div class="actions">
            ${book.isOwner
              ? html`<a class="button" href="/edit/${book._id}">Edit</a>
            <a @click=${onDelete} class="button" href="javascript:void(0)">Delete</a>`
             : nothing
             }
             ${!book.isOwner && user
              ? html`<a class="button" href="javascript:void(0)">Like</a>`
              : nothing 
              }

            <div class="likes">
                <img class="hearts" src="/images/heart.png">
                <span id="total-likes">Likes: 0</span>
            </div>
        </div>
    </div>
    <div class="book-description">
        <h3>Description:</h3>
        <p>${book.description}</p>
    </div>
</section>`;

export async function detailsPage(ctx){
    const bookId = ctx.params.id;
    const user = localStorage.getItem('user');
    const book = await booksService.getById(bookId);

    if (ctx.user) {
        book.isOwner = ctx.user._id == book._ownerId;
    }

    ctx.render(detailsTemplate(book, onDelete, user));

    async function onDelete(){
        const choice = confirm('Are you sure you want to delete this book?');
        if (choice) {
            await booksService.deleteById(bookId);
            ctx.page.redirect('/');
        }
    }
}