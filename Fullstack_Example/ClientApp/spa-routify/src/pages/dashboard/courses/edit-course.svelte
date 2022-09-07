<script>
    import { params } from "@roxi/routify";
    import { onMount } from "svelte";
    import { Command, CommandNames } from "../../../models/command";
    import CommandService, {
        sendCommand,
    } from "../../../services/command-service";

    export let id = $params.id;
    export let name = $params.name;

    let courseName = "";
    let courseContent = "";
    let commandService = new CommandService();

    onMount(async () => {
        let command = new Command();
        command.name = CommandNames.GetCourseById;

        const data = { id: id };
        command.requestData = data;

        let res = await sendCommand(command);

        if (res != undefined) {
            console.log(res);
            courseName = res.name;
            courseContent = res.content;
        }
    });

    async function updateCourse() {
        let command = new Command();
        command.name = CommandNames.UpdateCourse;

        const data = {
            name: courseName,
            topicId: id.test,
            content: courseContent,
        };

        command.requestData = data;
        console.log(data);

        var res = sendCommand(command);
        console.log(res);
    }
</script>

<div class="ui">
    <h4>Edit course: {name}</h4>
    <input bind:value={courseName} placeholder="enter topic name" />
    <textarea bind:value={courseContent} />
    <button on:click={updateCourse}>Update course</button>
</div>

<style>
    .ui {
        max-width: 300px;
    }
</style>
