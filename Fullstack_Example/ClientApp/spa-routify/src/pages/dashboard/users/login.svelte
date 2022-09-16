<script>
    import { Command, CommandNames } from "../../../models/command";
    import { sendAuthCommand } from "../../../services/command-service";
    import { url } from "@roxi/routify";

    let username, password;

    async function onLogin() {
        var command = new Command();
        command.name = CommandNames.UserLogin;

        command.requestData = {
            username: username,
            password: password,
        };

        try {
            var res = await sendAuthCommand(command);
            if (res.token != undefined) {
                let token = res.token;
                sessionStorage.setItem("token", token);
                console.log(res);
            }
        } catch (error) {
            console.log(error);
        }
    }
</script>

<p>Login page</p>

<input bind:value={username} placeholder="User name" />
<input bind:value={password} placeholder="Password" />

<button on:click={onLogin}>Login</button>
<hr/>
<a href={$url("./register")}>register </a>
