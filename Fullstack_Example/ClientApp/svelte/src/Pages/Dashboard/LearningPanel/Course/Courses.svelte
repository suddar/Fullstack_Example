<script lang="ts">
    import type { Course } from "src/Models/Course";
    export let courses: Course[] = [];
</script>

<div class="course-panel">
    <ul>
        {#each courses as course}
            <li>
                <p>{course.name}</p>
            </li>
        {/each}
    </ul>
    <div>
        <button>Add Course</button>
    </div>
</div>

<style>
    .course-panel {
        padding: 16px;
        background-color: azure;
        float: left;
    }
</style>
