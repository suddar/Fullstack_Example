<script>
import { Command, CommandNames } from "../../../../models/command";

import CommandService from "../../../../services/command-service";


    export let id;
    let name = "";

    let commandService = new CommandService();

    async function updateCourse() {
        let command = new Command();
        command.name = CommandNames.UpdateCourse;

        const course = { id: id, name: name };
        command.requestData = course;

        await commandService.send(command);
    }
</script>

<h2>This is edit course, Id: {id}</h2>

<input bind:value={name} placeholder="enter topic name" />
<p>topic {name || ""}!</p>

<button on:click={updateCourse}>Update course</button>
