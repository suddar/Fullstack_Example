import axios from 'axios';

export default class CommandService {
    baseUrl = "https://localhost:5555/api";

    async send(command) {
        try {
            let response = await axios.post(this.baseUrl, command);
            return response.data
        } catch (error) {
          return undefined;   
        }
    }
}
