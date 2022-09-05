<script>
    import { Command, CommandNames } from "../../../../models/command";
    import CommandService from "../../../../services/command-service";

    export let id;
    let name = "";

    let commandService = new CommandService();

    async function updateTopic() {
        let command = new Command();
        command.name = CommandNames.UpdateTopic;

        const topic = { id: id, name: name };
        command.requestData = topic;

        await commandService.send(command);
    }
</script>

<h2>This is edit topic, Id: {id}</h2>

<input bind:value={name} placeholder="enter topic name" />
<p>topic {name || ""}!</p>

<button on:click={updateTopic}>Update topic</button>
