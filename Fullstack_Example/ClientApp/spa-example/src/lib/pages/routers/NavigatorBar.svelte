<!-- App.svelte -->
<script>
    import { Router, Link, Route } from "svelte-routing";
    import Dashboard from "../dashboard/Dashboard.svelte";
    import Home from "../home.svelte";
    export let url = "";
</script>

<Router {url}>
    <nav>
        <Link to="/">Home</Link>
        <Link to="Dashboard">Dashboard</Link>
    </nav>
    <div>
        <Route path="Dashboard" component={Dashboard} />
        <Route path="/"><Home /></Route>
    </div>
</Router>
