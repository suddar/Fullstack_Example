<script>
    import { Command, CommandNames } from "../../../models/command";
    import { params } from "@roxi/routify";
    import { sendCommand } from "../../../services/command-service";

    export let id = $params.id;
    //export let name = $params.name;
    let courseName = "";
    let courseContent = "";

    async function createCourse() {
        let command = new Command();
        command.name = CommandNames.CreateCourse;

        const data = {
            name: courseName,
            topicId: id,
            content: courseContent,
        };

        command.requestData = data;
        var res = sendCommand(command);

        console.log(res);
    }
</script>

<div class="ui">
    <h4>Edit course: {courseName}</h4>
    <input bind:value={courseName} placeholder="enter topic name" />
    <textarea bind:value={courseContent} />

    <button on:click={createCourse}>Create course</button>
</div>

<style>
    .ui {
        max-width: 300px;
    }
</style>
