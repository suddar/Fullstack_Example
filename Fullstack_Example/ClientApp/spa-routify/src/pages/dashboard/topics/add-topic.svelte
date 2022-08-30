<script>
    import { Command, CommandName } from "../../../models/command";
    import CommandService from "../../../services/command-service";

    let commandService = new CommandService();
    let topicName = "";

    async function addTopic() {
        let command = new Command();
        command.commandName = CommandName.TOPIC_CREATE;
        const topic = { name: topicName };
        command.requestData = JSON.stringify(topic);

        // let topic = { name: topicName };
        // let command = {
        //     name: 0,
        //     requestData: JSON.stringify(topic),
        // };

        // const topic = {
        //     name: "topic test 666555555555",
        // };

        // const command = {
        //     name: 0,
        //     requestData: topic,
        // };

        var res = commandService.send(command);
        console.log(res);
    }
</script>

<input bind:value={topicName} placeholder="enter topic name" />
<p>topic {topicName || ""}!</p>

<button on:click={addTopic}>Add topic</button>
