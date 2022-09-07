<script>
    import { url } from "@roxi/routify";
    import { onMount } from "svelte";
    import { Command, CommandNames } from "../../../models/command";
    import { sendCommand } from "../../../services/command-service";

    let topics = [];

    onMount(async () => {
        await getTopics();
    });

    async function getTopics() {
        let command = new Command();
        command.name = CommandNames.GetTopics;
        topics = await sendCommand(command);
    }

    async function removeTopic(id) {
        let command = new Command();
        command.name = CommandNames.DeleteTopic;

        const data = { id: id };
        command.requestData = data;

        await sendCommand(command);
        await getTopics();
    }
</script>

<div>
    <h3>Topics</h3>
    <hr />
    <a href={$url("/dashboard/topics/add-topic")}>+Add topic</a>
</div>

<div>
    {#each topics as topic}
        <div class="topic-item">
            <a
                href={$url("/dashboard/courses/view-courses", {
                    topicId: topic.id,
                    topicName: topic.name,
                })}>{topic.name}</a
            >
            <a
                class="edit-icon"
                href={$url("/dashboard/topics/edit-topic", {
                    id: topic.id,
                })}
            >
                <i class="fa-solid fa-pen-to-square" />
            </a>
            <span on:click={() => removeTopic(topic.id)}>
                <i class="fa-solid fa-xmark" />
            </span>
        </div>
    {/each}
</div>

<style>
    .topic-item a {
        padding-left: 6px;
    }
    .topic-item span {
        padding-left: 6px;
        font-size: small;
        cursor: pointer;
    }
    .edit-icon {
        font-size: small;
    }
</style>
