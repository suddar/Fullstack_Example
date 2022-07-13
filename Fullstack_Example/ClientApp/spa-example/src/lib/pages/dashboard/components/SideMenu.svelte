<script>
    import { Link, link, Route, Router } from "svelte-navigator";
    import { navigate } from "svelte-navigator";
    import TopicList from "../topic/TopicList.svelte";

    export let location;

    console.log(location);

    function backToHome() {
        navigate("/dashboard/", { replace: true });
    }

    import { useFocus } from "svelte-navigator";

const registerFocus = useFocus();
</script>

<Router primary={false}>
    <ul>
        <li><Link to="course" replace={true}>course</Link></li>
        <li><Link to="topic" replace={true}>topic</Link></li>
    </ul>
</Router>

<!-- Somewhere inside a Route -->
<p use:registerFocus></p>