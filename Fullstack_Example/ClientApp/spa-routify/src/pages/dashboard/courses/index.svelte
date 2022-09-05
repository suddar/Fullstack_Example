<!-- <script>
    import { onMount } from "svelte/types/runtime/internal/lifecycle";
    import { Command, CommandNames } from "../../../models/command";

    import CommandService from "../../../services/command-service";

    let commandService = new CommandService();
    let topics = [];

    onMount(async () => {
        await getTopics();
    });

    async function getTopics() {
        let command = new Command();
        command.name = CommandNames.GetTopicById;
        topics = await commandService.send(command);
    }
</script> -->

<h1>This is courses</h1>
