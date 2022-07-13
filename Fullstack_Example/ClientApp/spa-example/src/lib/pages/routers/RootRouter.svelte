<!-- App.svelte -->
<script>
    import { Link, Route, Router } from "svelte-navigator";
    import Index from "../About/Index.svelte";
    import CourseList from "../dashboard/course/CourseList.svelte";
    import Dashboard from "../dashboard/Index.svelte";
    import TopicList from "../dashboard/topic/TopicList.svelte";
    import Home from "../home.svelte";
    import NotFound from "../NotFound/NotFound.svelte";
</script>

<Router primary={false}>
    <nav>
        <Link to="/">Home</Link>
        <Link to="dashboard">Dashboard</Link>
        <Link to="about">About</Link>
    </nav>
    <div>
        <Route path="dashboard" component={Dashboard} />
        <Route path="about" component={Index} />
        <Route path="/"><Home /></Route>

        <Route path="dashboard/topic" component={TopicList} />
        <Route path="dashboard/course" component={CourseList} />

        <Route path="" component={NotFound} />
    </div>
</Router>
