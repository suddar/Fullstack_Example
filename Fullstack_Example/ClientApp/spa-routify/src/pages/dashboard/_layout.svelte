<script>
    import { url } from "@roxi/routify";
</script>

<nav class="sidenav">
    <ul>
        <li><a href={$url("./topics")}>Topics </a></li>
        <li><a href={$url("./users")}>Users </a></li>
    </ul>
</nav>
<!-- routify:options preload="proximity" -->
<div class="main">
    <slot/>
</div>

<style>
    .sidenav ul li{
        list-style-type: none;
    }
</style>