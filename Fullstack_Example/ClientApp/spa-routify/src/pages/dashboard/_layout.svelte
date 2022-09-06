<script>
    import { url } from "@roxi/routify";
</script>

<nav>
    <ul>
        <li><a href={$url("./topics")}>Topics </a></li>
        <li><a href={$url("./users")}>Users </a></li>
    </ul>
</nav>
<!-- routify:options preload="proximity" -->
<slot />
