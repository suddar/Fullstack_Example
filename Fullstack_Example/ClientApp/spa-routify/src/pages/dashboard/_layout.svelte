<script>
    import { url } from "@roxi/routify";
</script>

<nav>
    <ul>
        <li><a href={$url("./topics")}>topics </a></li>
        <li><a href={$url("./courses")}>courses </a></li>
    </ul>
</nav>
<!-- routify:options preload="proximity" -->
<slot />
