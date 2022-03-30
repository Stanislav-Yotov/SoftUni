import * as request from './requester.js';



const baseUrl = 'http://localhost:3030/data/albums';

export const getAll = () => request.get(`${baseUrl}?sortBy=_createdOn%20desc&distinct=name`);

export const getOne = (albumID) => request.get(`${baseUrl}/${albumID}`);

export const create = (albumData) => request.post(baseUrl, albumData);

export const edit = (albumID, albumData) => request.put(`${baseUrl}/${albumID}`, albumData); 

export const remove = (albumID) => request.del(`${baseUrl}/${albumID}`);

export const search = (search) => {
    const query = encodeURIComponent(`name LIKE "${search}"`)
    return request.get(`${baseUrl}?where=${query}`);
};