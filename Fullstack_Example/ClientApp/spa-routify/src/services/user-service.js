import axios from 'axios';
const baseUrl = 'https://localhost:5555/api';

export async function login(user, pwd) {
    let url = `${baseUrl}/Authenticate/login`;

    let data = { username: user, password: pwd };
    console.log(JSON.stringify(data));

    let response = await axios.post(url, data);
    return response;
}

export async function register(user, email, pwd) {
    let url = `${baseUrl}/Authenticate/register`;

    let data = { username: user, email: email, password: pwd };
    console.log(JSON.stringify(data));

    let response = await axios.post(url, data);
    return response;
}