<script>
	import { Topic } from '$lib/models/Topic';
	import { createEntity } from '$lib/services/entitty-service';

	let entityName = '';

	async function addEntity() {
		let newTopic = new Topic(entityName);
		let res = await createEntity('Topic', newTopic);
		console.log(res);
	}
</script>

<h3>Add topic</h3>

<input bind:value={entityName} />

<h3>Topic name {entityName}</h3>

<button on:click={addEntity}>Add</button>
