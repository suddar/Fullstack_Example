<script>
    import { addTopicMutation } from "../../../schemas/topics-schema";
    import { query } from "../../../services/graphql-service";

    let name = "";

    async function addTopic() {
        let response = await query(addTopicMutation(name));
        console.log(response);
    }
    
</script>

<input bind:value={name} placeholder="enter topic name" />
<p>topic {name || ""}!</p>

<button on:click={addTopic}>Add topic</button>
