<script>
    import { Command, CommandNames } from "../../../../models/command";
    import CommandService from "../../../../services/command-service";

    export let id;
    let commandService = new CommandService();
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
        console.log(data);
        var res = commandService.send(command);
        console.log(res);
    }
</script>

<div>
    <input bind:value={courseName} placeholder="enter course name" />
    <textarea bind:value={courseContent} />

    <p>topic {courseName || ""}!</p>
    <p>topic id {id}</p>

    <p>Content {courseContent || ""}!</p>

    <button on:click={createCourse}>Create course</button>
</div>
