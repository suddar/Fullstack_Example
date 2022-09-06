<script>
    import { url } from "@roxi/routify";
    import { onMount } from "svelte";
    import { Command, CommandNames } from "../../../models/command";
    import CommandService from "../../../services/command-service";

    export let topicId;
    let courses = [];

    let commandService = new CommandService();

    onMount(async () => {
        await getCourses();
    });

    async function getCourses() {
        let command = new Command();
        command.name = CommandNames.GetTopicById;

        const topic = { id: topicId };
        command.requestData = topic;

        let res = await commandService.send(command);

        courses = res.courses;
        console.log(res);
    }
</script>

<ul>
    {#each courses as course}
        <li>
            <a
                href={$url("/dashboard/courses/edit-course/:id", {
                    id: course.id,
                })}
            >
                {course.name}</a
            >
        </li>
    {/each}
</ul>
<p>This is course detail, topic id {topicId}</p>

<a href={$url("/dashboard/courses/add-course/:id", {id: topicId, })}> Create course</a>