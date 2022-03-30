import { html, nothing } from '../../../node_modules/lit-html/lit-html.js';
import { albumDetails } from '../catalogView.js';

export const albumTemplate = (album, withDetails = true) => html`
    <div class="card-box">
        <img src=${album.imgUrl}>
        <div>
            <div class="text-center">
                <p class="name">Name: ${album.name}</p>
                <p class="artist">${album.artist}</p>
                <p class="genre">Genre: ${album.genre}</p>
                <p class="price">Price: ${album.price}</p>
                <p class="date">Release Date: ${album.releaseDate}</p>
            </div>
            ${withDetails
                ? albumDetails(album._id)
                : nothing
            }
            
        </div>
    </div>
`;