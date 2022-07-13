<script>
	import { Course } from '$lib/models/Course';

	import { createEntity } from '$lib/services/entitty-service';
	import { currentTopicId } from '$lib/services/storage';
	import { get } from 'svelte/store';

	let courseName = '';
	let topicId = get(currentTopicId);

	async function addEntity() {
		let newCourse = new Course(courseName, topicId);
		let res = await createEntity('Course', newCourse);
		console.log(res);
	}
</script>

<h3>Add course</h3>

<input bind:value={courseName} />

<h3>topicId {topicId}</h3>
<h3>Course name {courseName}</h3>

<button on:click={addEntity}>Add</button>

<div>
	<a href="/dashboard/topics">Back to topics</a>
</div>
