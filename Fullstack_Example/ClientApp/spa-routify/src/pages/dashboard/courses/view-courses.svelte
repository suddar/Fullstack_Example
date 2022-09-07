<script>
    import { url, params } from "@roxi/routify";
    import { onMount } from "svelte";
    import { Command, CommandNames } from "../../../models/command";
    import { sendCommand } from "../../../services/command-service";

    export let topicId = $params.topicId;
    export let topicName = $params.topicName;
    let courses = [];

    onMount(async () => {
        await getCourses();
    });

    async function getCourses() {
        let command = new Command();
        command.name = CommandNames.GetTopicById;

        const topic = { id: topicId };
        command.requestData = topic;

        let res = await sendCommand(command);

        courses = res.courses;
        console.log(res);
    }

    async function removeCourse(id) {
        console.log(`remove course: ${id}`);
        let command = new Command();
        command.name = CommandNames.DeleteCourse;

        const data = { id: id };
        command.requestData = data;

        await sendCommand(command);
        await getCourses();
    }
</script>

<p>Courses, topic {topicName}</p>

<ul>
    {#each courses as course}
        <li>
            <a
                href={$url("/dashboard/courses/edit-course", {
                    id: course.id,
                    name: course.name,
                })}>{course.name}</a
            >
            <span on:click={() => removeCourse(course.id)}>
                <i style="cursor:pointer ;" class="fa-solid fa-xmark" />
            </span>
        </li>
    {/each}
</ul>

<a href={$url("/dashboard/courses/add-course", { id: topicId })}>
    Create course</a
>
