<script>
    import Login from "./login.svelte";

</script>
<!-- <script>
    import axios from "axios";
    import { login, register } from "../../../services/user-service";

    let username, password, email;
    async function onLogin() {
        try {
            let res = await login(username, password);
            if (res.data.token != undefined) {
                let token = res.data.token;
                sessionStorage.setItem("token", token);
                axios.defaults.headers.common[
                    "Authorization"
                ] = `Bearer + ${token}}`;
                console.log(res);
            }
        } catch (error) {
            console.log(error);
        }
    }

    async function onRegister() {
        let res = await register(username, email, password);
        if (res.data.token != undefined) {
            let token = res.data.token;
            sessionStorage.setItem("token", token);
            axios.defaults.headers.common[
                "Authorization"
            ] = `Bearer + ${token}}`;
            console.log(res);
        }
    }
</script>

<p>User page</p>

<input bind:value={username} placeholder="User name" />
<input bind:value={password} placeholder="Password" />

<button on:click={onLogin}>Login</button>

<hr/>

<input bind:value={username} placeholder="User name" />
<input bind:value={password} placeholder="Password" />
<input bind:value={email} placeholder="Email" />

<button on:click={onRegister}>Register</button> -->

<Login/>