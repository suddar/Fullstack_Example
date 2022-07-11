<script lang="ts">
	import { getEntities, getEntityById, removeEntity } from '$lib/services/entitty-service';
	import type { Course } from '$lib/models/Course';
	import type { Topic } from '$lib/models/Topic';
	import { onMount } from 'svelte';
	import { currentCourseId, currentTopicId } from '$lib/services/storage';

	let topics: Topic[] = [];
	let courses: Course[] = [];

	onMount(async () => {
		let response = await getEntities<Topic>('Topic');
		topics = response.data;
	});

	async function showCourses(topicId: number) {
		currentTopicId.set(topicId);
		let response = await getEntityById<Topic>('Topic', topicId);
		courses = response.data.courses;
	}

	async function removeTopic(topicId: number) {
		await removeEntity('Topic', topicId);
		let res = await getEntities<Topic>('Topic');
		topics = res.data;
	}

	async function removeCourse(courseId: number, topicId: number) {
		await removeEntity('Course', courseId);
		await showCourses(topicId);
	}
</script>

<div class="topic-items">
	<h3>topic items</h3>
	<a href="/dashboard/topics/add-topic">
		<i class="fa-solid fa-plus" /> Add topic
	</a>

	<ul>
		{#each topics as topic}
			<li>
				<span on:click={() => showCourses(topic.id)}>{topic.name}</span>
				<a href="/dashboard/topics/edit-topic" on:click={() => currentTopicId.set(topic.id)}>
					<i class="fa-solid fa-pen-to-square" />
				</a>
				<span on:click={() => removeTopic(topic.id)}>
					<i class="fa-solid fa-xmark" />
				</span>
			</li>
		{/each}
	</ul>
</div>

<div class="courses-list">
	<h3>course items</h3>
	<a href="/dashboard/courses/add-course">
		<i class="fa-solid fa-plus" /> Add course
	</a>
	<ul>
		{#each courses as course}
			<li>
				{course.name}
				<a href="/dashboard/courses/edit-course" on:click={() => currentCourseId.set(course.id)}>
					<i class="fa-solid fa-pen-to-square" />
				</a>
				<span on:click={() => removeCourse(course.id, course.topicId)}>
					<i class="fa-solid fa-xmark" />
				</span>
			</li>
		{/each}
	</ul>
</div>

<style lang="scss">
	.topic-items {
		ul {
			list-style-type: none;
			li {
				background-color: burlywood;
				margin-top: 2px;
				padding: 6px;
				span {
					cursor: pointer;
				}
			}
		}
	}
	.courses-list {
		ul {
			list-style-type: none;
			li {
				background-color: antiquewhite;
				margin-top: 2px;
				padding: 6px;
			}
		}
	}
</style>
