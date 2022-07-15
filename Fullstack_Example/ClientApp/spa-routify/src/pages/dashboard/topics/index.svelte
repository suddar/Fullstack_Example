<script>
    import { url } from "@roxi/routify";
</script>

<h1>This is topics</h1>

<a href={$url("/dashboard/topics/:id", { id: 1 })}>topic 1</a>
<a href={$url("/dashboard/topics/:id", { id: 2 })}>topic 2</a>
