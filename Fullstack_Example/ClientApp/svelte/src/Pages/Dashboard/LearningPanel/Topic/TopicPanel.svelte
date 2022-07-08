<script>
    import TopicItem from "./TopicItem.svelte";
</script>

<div class="topic-panel">
    <h3>Topic</h3>
    <ul class="topic-ul">
        <li><TopicItem /></li>
        <li><TopicItem /></li>
        <li><TopicItem /></li>
    </ul>
</div>

<style>
    .topic-panel {
        width: 350px;
        background-color: #d2f2f7;
        float: left;
    }
</style>