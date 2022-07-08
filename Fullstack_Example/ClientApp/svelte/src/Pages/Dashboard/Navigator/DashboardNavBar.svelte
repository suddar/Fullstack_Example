<script lang="ts">
    import LearningPanel from "./../LearningPanel/LearningPanel.svelte";
    import UserPanel from "./../UserPanel/UserPanel.svelte";
    import { Button } from "sveltestrap";
    import { createEventDispatcher } from "svelte";
    import NavBarItem from "./NavBarItem.svelte";
    import { Messenger } from "../../../lib/messenger";
</script>

<div class="db-nav-bar">
    <nav>
        <NavBarItem
            icon="fa-regular fa-user fa-lg"
            text="User"
            componentName="UserPanel"
        />
        <NavBarItem
            icon="fa-regular fa-address-book fa-lg"
            text="Learning"
            componentName="LearningPanel"
        />
    </nav>
</div>

<style type="scss">
    .db-nav-bar {
        padding: 10px;
        background-color: bisque;
    }
</style>
