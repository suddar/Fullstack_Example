<script>
    import { url } from "@roxi/routify";
    import { onMount } from "svelte";

    import { Command, CommandNames } from "../../../models/command";
    import CommandService from "../../../services/command-service";

    let commandService = new CommandService();
    let topics = [];

    onMount(async () => {
        await getTopics();
    });

    async function getTopics() {
        let command = new Command();
        command.name = CommandNames.GetTopics;
        topics = await commandService.send(command);
    }

    async function removeTopic(id) {
        let command = new Command();
        command.name = CommandNames.DeleteTopic;

        const topic = { id: id };
        command.requestData = topic;

        await commandService.send(command);

        await getTopics();
    }

</script>

<h1>This is topics</h1>

<a href={$url("/dashboard/topics/add-topic?id=:id", { id: 0 })}>add topic</a>

<ul>
    {#each topics as topic}
        <li>
            <a href={$url("/dashboard/courses/:topicId", { topicId: topic.id })}>
                {topic.name}</a
            >
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
