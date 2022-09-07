<script>
    import { onMount } from "svelte";
    import { Command, CommandNames } from "../../../models/command";
    import { sendCommand } from "../../../services/command-service";
    let courses = [];

    onMount(async () => {
        await getCourses();
    });

    async function getCourses() {
        let command = new Command();
        command.name = CommandNames.GetCourses;
        courses = await sendCommand(command);
    }
</script>

<h1>This is courses page</h1>

{#each courses as course}
    <li>
        {course.name}
    </li>
{/each}