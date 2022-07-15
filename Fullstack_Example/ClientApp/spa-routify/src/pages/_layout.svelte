<!-- src/pages/recipes/cakes/cupcakes.svelte -->
<script>
    import { url } from "@roxi/routify";
    //get current path
    //console.log($url()); //'recipes/cakes/cupcakes'
</script>

<nav>
    <a href={$url("./")}> Home </a>
    <a href={$url("./dashboard")}> dashboard </a>
    <a href={$url("./about")}> about </a>
</nav>
<!-- routify:options preload="proximity" -->
<slot />
