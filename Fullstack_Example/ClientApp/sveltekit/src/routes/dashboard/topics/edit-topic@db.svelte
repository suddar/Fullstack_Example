<script>
	import { Topic } from '$lib/models/Topic';
	import { updateEntity } from '$lib/services/entitty-service';
	import { currentTopicId } from '$lib/services/storage';
	import { get } from 'svelte/store';

	let entityName = '';
	let topicId = get(currentTopicId);

	async function editEntity() {
		let newTopic = new Topic(entityName, topicId);
		let res = await updateEntity('Topic', newTopic);
	}
</script>

<h3>Edit topic</h3>

<input bind:value={entityName} />

<h3>Topic name {entityName}</h3>

<button on:click={editEntity}>Save</button>

<div>
	<a href="/dashboard/topics">Back to topics</a>
</div>
