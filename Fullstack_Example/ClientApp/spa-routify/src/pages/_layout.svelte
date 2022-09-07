<!-- src/pages/recipes/cakes/cupcakes.svelte -->
<script>
    import { url } from "@roxi/routify";
    //get current path
    //console.log($url()); //'recipes/cakes/cupcakes'
</script>

<nav class="topnav">
    <a href={$url("./")}> Home </a>
    <a href={$url("./dashboard")}> Dashboard </a>
    <a href={$url("./about")}> About </a>
</nav>
<!-- routify:options preload="proximity" -->
<slot />
