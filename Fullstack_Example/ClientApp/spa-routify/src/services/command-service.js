import axios from 'axios';

export default class CommandService {
    baseUrl = "https://localhost:5555/api";

    async send(command) {

        const topic = {
            name:"topic test 7"
        }

        const data = {
            name: 0,
            requestData:JSON.stringify(topic)
        };

        console.log(command);

        let response = await axios.post(this.baseUrl, command);
        return response.data.result
    }
}
