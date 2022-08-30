<script>
    export let id;
    let name = "";

    async function updateTopic() {}
</script>

<h2>This is edit topic, Id: {id}</h2>

<input bind:value={name} placeholder="enter topic name" />
<p>topic {name || ""}!</p>

<button on:click={updateTopic}>Update topic</button>
