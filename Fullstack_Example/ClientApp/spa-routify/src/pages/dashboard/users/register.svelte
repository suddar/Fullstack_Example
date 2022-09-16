<script>
    import { Command, CommandNames } from "../../../models/command";
    import { sendCommand } from "../../../services/command-service";
    import { url } from "@roxi/routify";

    let username, password, email;

    async function onRegister() {
        var command = new Command();
        command.name = CommandNames.UserRegister;

        command.requestData = {
            username: username,
            password: password,
            email: email,
        };

        var res = await sendCommand(command);
        console.log(res);
    }
</script>

<p>Register page</p>

<input bind:value={username} placeholder="User name" />
<input bind:value={password} placeholder="Password" />
<input bind:value={email} placeholder="Email" />

<button on:click={onRegister}>Register</button>
<hr/>
<a href={$url("./login")}>login </a>
