<script lang="ts">
    import DashboardContent from "./DashboardContent.svelte";
    import type { Topic } from "src/Models/Topic";
    import { onMount } from "svelte";
    import { EntittyService } from "../../lib/entitty-service";
    import { Button } from "sveltestrap";

    var service = new EntittyService();
    let topics: Topic[] = [];
    var dashboardContent: DashboardContent;

    var component: any;
    var props: any;

    async function onTopicItemClick(value) {
        if (dashboardContent != null) await dashboardContent.loadTopic(value);
        component = DashboardContent;
        props = { topicId: value };
    }

    function createTopic() {}

    onMount(async () => {
        var response = await service.getEntities<Topic>("Topic");
        topics = response.data;

        component = DashboardContent;
        props = { topicId: 1 };
    });
</script>

<nav class="left-panel">
    <div class="topic-title">
        <h3>Topic</h3>
    </div>
    <div>
        <ul style="padding-left:0px ;">
            {#each topics as topic}
                <li style="list-style-type:none ;">
                    <p on:click={() => onTopicItemClick(topic.id)}>
                        {topic.name} <span><Button>x</Button></span>
                    </p>
                </li>
            {/each}
        </ul>
    </div>
    <div class="topic-control-panel">
        <Button>Add</Button>
        <Button>Edit</Button>
        <Button>Remove</Button>
    </div>
</nav>

<div class="right-panel">
    <!-- <DashboardContent prop1={topicId} bind:this={dashboardContent} /> -->
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
