<!-- App.svelte -->
<script>
    import { Router, Link, Route } from "svelte-routing";
    import Dashboard from "../Dashboard/Dashboard.svelte";
    import Home from "../Home/Home.svelte";
    export let url = "";
</script>

<Router {url}>
    <nav class="top-navbar">
        <Link to="/">Home</Link>
        <Link to="dashboard">Dashboard</Link>
    </nav>
    <div>
        <Route path="/dashboard" component={Dashboard} />
        <Route path="/"><Home /></Route>
    </div>
</Router>

<style>
    .top-navbar {
        background-color: slategrey;
        padding: 10px;
    }
</style>
