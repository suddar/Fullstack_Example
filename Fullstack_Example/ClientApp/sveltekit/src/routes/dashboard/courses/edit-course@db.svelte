<script>
	import { Course } from '$lib/models/Course';
	import { updateEntity } from '$lib/services/entitty-service';
	import { currentCourseId } from '$lib/services/storage';
	import { get } from 'svelte/store';

	let entityName = '';
	let courseId = get(currentCourseId);

	async function editEntity() {
		let newCourse = new Course(entityName, null, courseId);
		let res = await updateEntity('Course', newCourse);
		console.log(res);
	}
</script>

<h3>Edit Course</h3>

<input bind:value={entityName} />

<h3>Course name {entityName}</h3>

<button on:click={editEntity}>Save</button>

<div>
	<a href="/dashboard/topics">Back to topics</a>
</div>
