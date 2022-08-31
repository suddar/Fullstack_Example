<script>
    import { Command, CommandNames } from "../../../models/command";
    import CommandService from "../../../services/command-service";

    let commandService = new CommandService();
    let topicName = "";

    async function addTopic() {
        let command = new Command();
        command.name = CommandNames.CreateTopic;

        const topic = { name: topicName };
        command.requestData = topic;

        var res = commandService.send(command);
        console.log(res);
    }
</script>

<input bind:value={topicName} placeholder="enter topic name" />
<p>topic {topicName || ""}!</p>

<button on:click={addTopic}>Add topic</button>
