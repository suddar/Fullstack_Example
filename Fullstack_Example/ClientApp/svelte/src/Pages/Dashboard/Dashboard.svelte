<script lang="ts">
    import CoursePanel from "./Courses.svelte";
    import type { Topic } from "src/Models/Topic";
    import { onMount } from "svelte";
    import { EntittyService } from "../../lib/entitty-service";
    import { Button } from "sveltestrap";
    import AddTopic from "./AddTopic.svelte";
    import EditTopic from "./EditTopic.svelte";

    var service = new EntittyService();
    let topics: Topic[] = [];
    var component: any;
    var props: any;

    async function showCourses(topicId: number) {
        let response = await service.getEntityById<Topic>("Topic", topicId);
        let topic = response.data;
        component = CoursePanel;
        props = {
            courses: topic.courses,
        };
    }

    function createTopic() {
        component = AddTopic;
        props = { id: 1 };
    }
    function editTopic(id: number) {
        component = EditTopic;
        props = { topicId: id };
    }

    async function removeTopic(id: number) {
        await service.removeEntity("Topic", id);
        await getTopicItems();
    }

    async function getTopicItems() {
        var response = await service.getEntities<Topic>("Topic");
        topics = response.data;
        await showCourses(topics[0].id);
    }

    onMount(async () => {
        await getTopicItems();
    });
</script>

<nav class="left-panel">
    <div class="topic-title">
        <h3 style="display:inline-block ;">Topic</h3>
        <Button on:click={() => createTopic()}>Add</Button>
    </div>
    <div>
        <ul style="padding-left:0px ;">
            {#each topics as topic}
                <li style="list-style-type:none ;">
                    <div style="display: inline-block;">
                        <h4 on:click={() => showCourses(topic.id)}>
                            {topic.name}
                        </h4>
                    </div>
                    <div style="display: inline-block;float: right;">
                        <Button on:click={() => editTopic(topic.id)}
                            >Edit</Button
                        >
                        <button on:click={() => removeTopic(topic.id)}>x</button
                        >
                    </div>
                </li>
            {/each}
        </ul>
    </div>
</nav>

<div class="right-panel">
    <svelte:component this={component} {...props} />
</div>

<style>
    .left-panel {
        width: 30%;
        float: left;
        position: relative;
        padding: 0px;
    }
    .right-panel {
        width: 70%;
        float: left;
    }
    .topic-title {
        position: relative;
        bottom: 0px;
    }
    .topic-control-panel {
        padding: auto;
    }
    /* div {
        background-color: #e4e4ed;
        padding: 0px;
        margin: 0px;
    } */
</style>
