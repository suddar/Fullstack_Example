<script lang="ts">
    import { EntittyService } from "../../lib/entitty-service";
    import { onMount } from "svelte";
    import type { Course } from "src/Models/Course";
    import type { Topic } from "src/Models/Topic";

    var service = new EntittyService();
    export let topicId: number = 1;
    let topic: Topic;
    let courses: Course[] = [];

    onMount(async () => {
        await loadTopic(topicId);
    });

    export async function loadTopic(id: number) {
        let response = await service.getEntityById<Topic>("Topic", id);
        topic = response.data;
        courses = topic.courses;
    }
</script>

<ul>
    {#each courses as course}
        <li>
            <p>{course.name}</p>
        </li>
    {/each}
</ul>
