import axios from 'axios';
import { GetResult } from '../models/get-result';

export class EntityService {
    baseUrl = "https://localhost:5555/graphql/";
    controller = new AbortController();

    async getEntities(entityName) {
        let url = `${baseUrl}/${entityName}`;
        let response = await axios.get(url, { signal: controller.signal });
        return response.data;
    }

    async getEntityById(entityName, id) {
        let url = `${baseUrl}/${entityName}/${id}`;
        let response = await axios.get(url, { signal: controller.signal });
        return response.data;
    }

    async createEntity(entityName, entity) {
        let url = `${baseUrl}/${entityName}`;

        let repsonse = await axios.post(url, entity, { signal: controller.signal });
        return JSON.stringify(repsonse.data);
    }

    async updateEntity(entityName, entity) {
        let url = `${baseUrl}/${entityName}`;
        let repsonse = await axios.put(url, entity, { signal: controller.signal });
        return JSON.stringify(repsonse.data);
    }

    async removeEntity(entityName, id) {
        var url = `${baseUrl}/${entityName}/${id}`;
        let response = await axios.delete(url, { signal: controller.signal });
        return response;
    }

    abortRequest() {
        controller.abort();
    }

    //export { getEntities, getEntityById, createEntity, updateEntity, removeEntity, abortRequest }
}