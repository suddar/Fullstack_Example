import axios from 'axios';
baseUrl = 'https://localhost:5555/api'

export async function login(username, password) {
    let url = `${baseUrl}/Authenticate/login`;
    let response = await axios.post(url, { username: username, password: password });
    return response
}

export async function register(username, email, password) {
    let url = `${baseUrl}/Authenticate/register`;
    let response = await axios.post(url, { username: username, email: email, password: password });
    return response
}