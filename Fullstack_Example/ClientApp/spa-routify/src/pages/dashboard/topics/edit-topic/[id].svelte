<script>
    import { updateTopicMutation } from "../../../../schemas/topics-schema";
    import { query } from "../../../../services/graphql-service";

    export let id;
    let name = "";
    async function updateTopic() {
        let response = await query(updateTopicMutation(id, name));
        console.log(response);
    }
</script>

<h2>This is edit topic, Id: {id}</h2>

<input bind:value={name} placeholder="enter topic name" />
<p>topic {name || ""}!</p>

<button on:click={updateTopic}>Update topic</button>
