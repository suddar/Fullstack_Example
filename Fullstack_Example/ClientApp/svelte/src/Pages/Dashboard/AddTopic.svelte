<script lang="ts">
    import type { EntittyService } from "../../lib/entitty-service";
    import type { Course } from "src/Models/Course";
    import { onDestroy, onMount } from "svelte";

    export let id: number;
    let sv: EntittyService;
</script>

<p>topic {id}</p>
