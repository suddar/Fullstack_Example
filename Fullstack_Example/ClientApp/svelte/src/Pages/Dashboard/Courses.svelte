<script lang="ts">
    import type { Course } from "src/Models/Course";

    export let courses: Course[] = [];

</script>

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