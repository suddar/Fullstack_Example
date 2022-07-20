<script>
    import { url } from "@roxi/routify";
    import { onMount } from "svelte";

    import {
        removeTopicMutation,
        topicsQuery,
    } from "../../../schemas/topics-schema";
    import { query } from "../../../services/graphql-service";

    let topics = [];

    onMount(async () => {
        let response = await query(topicsQuery);
        topics = response.topics;
    });

    async function removeTopic(id) {
        await query(removeTopicMutation(id));
        let response = await query(topicsQuery);
        topics = response.topics;
    }
</script>

<h1>This is topics</h1>

<a href={$url("/dashboard/topics/add-topic?id=:id", { id: 0 })}>add topic</a>

<ul>
    {#each topics as topic}
        <li>
            <a href={$url("/dashboard/courses/:id",{id:topic.id})}> {topic.name}</a>
            <a
                href={$url("/dashboard/topics/edit-topic/:id", {
                    id: topic.id,
                })}
            >
                <i class="fa-solid fa-pen-to-square" />
            </a>
            <span on:click={() => removeTopic(topic.id)}>
                <i style="cursor:pointer ;" class="fa-solid fa-xmark" />
            </span>
        </li>
    {/each}
</ul>
