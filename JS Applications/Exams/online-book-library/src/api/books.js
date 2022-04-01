import * as api from './api.js';

const endpoints = {
    create: '/data/books',
    all: '/data/books?sortBy=_createdOn%20desc',
    byId: '/data/books/',
    byUserId: '/data/books'
};

export async function create(data){
    return api.post(endpoints.create, data);
}

export async function getAll(){
    return api.get(endpoints.all);
}

export async function getById(id){
    return api.get(endpoints.byId + id);
}

export async function deleteById(id){
    return api.del(endpoints.byId + id);
}

export async function update(id, data){
    return api.put(endpoints.byId + id, data)
}

export async function getByUserId(userId){
    return api.get(endpoints.byUserId + `?where=_ownerId%3D%22${userId}%22&sortBy=_createdOn%20desc`);
}