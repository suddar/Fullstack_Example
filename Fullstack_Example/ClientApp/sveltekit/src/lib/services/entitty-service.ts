import axios from 'axios';
import type { GetResult } from '../models/Response/getResult';
//export class EntittyService {
let baseUrl = "https://localhost:5555/api";

const controller = new AbortController();

async function getEntities<T>(entityName: string): Promise<GetResult<T[]>> {
    let url = `${baseUrl}/${entityName}`;
    let response = await axios.get(url, { signal: controller.signal });
    return response.data;
}

async function getEntityById<T>(entityName: string, id: number): Promise<GetResult<T>> {
    let url = `${baseUrl}/${entityName}/${id}`;
    let response = await axios.get(url, { signal: controller.signal });
    return response.data;
}

async function createEntity(entityName: string, entity: any) {
    let url = `${baseUrl}/${entityName}`;
    // return await fetch(, url{
    //     method: 'POST',
    //     body: JSON.stringify(entity),
    //     headers: {
    //         'Content-Type': 'application/json'
    //     },
    //     referrer: 'no-referrer'
    // }).then(x => x.json);

    let repsonse = await axios.post(url, entity, { signal: controller.signal });
    return JSON.stringify(repsonse.data);
}

async function updateEntity(entityName: string, entity: any) {
    let url = `${baseUrl}/${entityName}`;
    let repsonse = await axios.put(url, entity, { signal: controller.signal });
    return JSON.stringify(repsonse.data);
}

async function removeEntity(entityName: string, id: number) {
    var url = `${baseUrl}/${entityName}/${id}`;

    // return await fetch(url, {
    //     method: 'DELETE',
    //     headers: {
    //         'Content-Type': 'application/json'
    //     },
    //     referrer: 'no-referrer'
    // }).then(x => x.json);
    let response = await axios.delete(url, { signal: controller.signal });
    return response;
}
//}

function abortRequest() {
    controller.abort();
}

export { getEntities, getEntityById, createEntity, updateEntity, removeEntity, abortRequest }