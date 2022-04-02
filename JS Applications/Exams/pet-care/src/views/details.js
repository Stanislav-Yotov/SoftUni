import { html, nothing } from '../../node_modules/lit-html/lit-html.js';
import * as petService from '../api/pets.js';

const detailsTemplate = (pet, onDelete, user) => html`
<section id="detailsPage">
    <div class="details">
        <div class="animalPic">
            <img src=${pet.image}>
        </div>
        <div>
            <div class="animalInfo">
                <h1>Name: ${pet.name}</h1>
                <h3>Breed: ${pet.breed}</h3>
                <h4>Age: ${pet.age}</h4>
                <h4>Weight: ${pet.weight}</h4>
                <h4 class="donation">Donation: 0$</h4>
            </div>
            <div class="actionBtn">
                ${pet.isOwner
                   ? html`<a href="/edit/${pet._id}" class="edit">Edit</a>
                       <a @click=${onDelete} href="javascript:void(0)" class="remove">Delete</a>`
                   : nothing 
                 }

                ${!pet.isOwner && user
                    ? html`<a href="javascript:void(0)" class="donate">Donate</a>`
                    : nothing 
                 }
            </div>
        </div>
    </div>
</section>`;

export async function detailsPage(ctx) {
    const petId = ctx.params.id;
    const user = localStorage.getItem('user');
    const pet = await petService.getById(petId);

    if (ctx.user) {
        pet.isOwner = ctx.user._id == pet._ownerId;
    }

    ctx.render(detailsTemplate(pet, onDelete, user));

    async function onDelete(){
        const choice = confirm('Are you sure you want to delete this pet?');
        if (choice) {
            await petService.deleteById(petId);
            ctx.page.redirect('/');
        }
    }
}