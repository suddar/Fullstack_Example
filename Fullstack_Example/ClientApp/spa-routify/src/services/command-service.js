import axios from 'axios';

export default class CommandService {
    baseUrl = "https://localhost:5555/api";

    async send(command) {
        try {
            let token = sessionStorage.getItem("token");
            let authorization = {
                headers: {
                    'Authorization': `Bearer ${token}`
                }
            };
            let response = await axios.post(this.baseUrl, command, authorization);
            return response.data
        } catch (error) {
            return undefined;
        }
    }
}

export async function sendCommand(command) {
    try {
        let baseUrl = "https://localhost:5555/api";
        let token = sessionStorage.getItem("token");
        let authorization = {
            headers: {
                'Authorization': `Bearer ${token}`
            }
        };
        let response = await axios.post(baseUrl, command, authorization);
        return response.data
    } catch (error) {
        return undefined;
    }
}

export async function sendAuthCommand(command) {
    try {
        let baseUrl = "https://localhost:5555/api/auth";
        let response = await axios.post(baseUrl, command);
        return response.data
    } catch (error) {
        return undefined;
    }
}