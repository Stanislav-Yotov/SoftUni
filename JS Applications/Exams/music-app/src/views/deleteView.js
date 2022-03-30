import * as albumService from '../services/albumService.js';

export const deleteView = async (ctx) => {
    try {
        const album = await albumService.getOne(ctx.params.albumID);

        let confirmed = confirm(`Do you want to delete the album: ${album.name}`);
        if (confirmed) {
            await albumService.remove(ctx.params.albumID);
            ctx.page.redirect('/catalog');
        }

        
        
    } catch (error) {
        alert(err);
    }

};