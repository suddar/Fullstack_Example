<script>
    import { onMount } from "svelte";
    import { Command, CommandNames } from "../../../../models/command";
    import CommandService from "../../../../services/command-service";

    export let id;
    let courseName = "";
    let courseContent = "";

    let commandService = new CommandService();

    onMount(async () => {
        let command = new Command();
        command.name = CommandNames.GetCourseById;

        const data = { id: id };
        command.requestData = data;

        let res = await commandService.send(command);

        if(res!=undefined){
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
            topicId: id,
            content: courseContent,
        };

        command.requestData = data;

        console.log(data);
        var res = commandService.send(command);
        console.log(res);
    }
</script>

<h2>This is edit course, Id: {id}</h2>

<input bind:value={courseName} placeholder="enter topic name" />
<p>topic {courseName || ""}!</p>
<textarea bind:value={courseContent} />

<button on:click={updateCourse}>Update course</button>
