import axios from 'axios';
import type { GetResult } from '../Models/Response/GetResult';
export class EntittyService {
    baseUrl = "https://localhost:5555/api";

    async getEntities<T>(entityName: string): Promise<GetResult<T[]>> {
        let url = `${this.baseUrl}/${entityName}`;
        let response = await axios.get(url);
        return response.data;
    }

    async getEntityById<T>(entityName: string, id: number): Promise<GetResult<T>> {
        let url = `${this.baseUrl}/${entityName}/${id}`;
        let response = await axios.get(url);
        return response.data;
    }

    async createEntity(entityName: string, entity: any) {
        let url = `${this.baseUrl}/${entityName}`;
        // return await fetch(, url{
        //     method: 'POST',
        //     body: JSON.stringify(entity),
        //     headers: {
        //         'Content-Type': 'application/json'
        //     },
        //     referrer: 'no-referrer'
        // }).then(x => x.json);

        let repsonse = await axios.post(url, entity);
        return JSON.stringify(repsonse.data);
    }

    async removeEntity(id: number, entityName: string) {
        var url = `${this.baseUrl}/${entityName}/${id}`;

        // return await fetch(url, {
        //     method: 'DELETE',
        //     headers: {
        //         'Content-Type': 'application/json'
        //     },
        //     referrer: 'no-referrer'
        // }).then(x => x.json);
        let response = await axios.delete(url);
        return response;
    }
}