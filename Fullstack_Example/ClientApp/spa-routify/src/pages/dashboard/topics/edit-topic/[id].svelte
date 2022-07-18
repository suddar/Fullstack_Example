<script>
    import { updateTopicMutation } from "../../../../schemas/topics-schema";

    let name = "";
    async function updateTopic() {
        let response = await query(updateTopicMutation(name));
        console.log(response);
    }
</script>

<h2>This is edit topic</h2>

<input bind:value={name} placeholder="enter topic name" />
<p>topic {name || ""}!</p>

<button on:click={updateTopic}>Update topic</button>
