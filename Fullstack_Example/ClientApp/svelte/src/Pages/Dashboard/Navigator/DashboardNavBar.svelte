<script lang="ts">
    import { Button } from "sveltestrap";
    import { createEventDispatcher } from "svelte";
    import NavBarItem from "./NavBarItem.svelte";
    import { Messenger } from "../../../lib/messenger";
</script>

<div class="db-nav-bar">
    <nav>
        <NavBarItem icon="fa-regular fa-user fa-lg" text="User" />
        <span style="font-size: 1em; color: darkcyan;">
            <i class="fa-regular fa-address-book fa-lg" />
            Learning
        </span>
    </nav>
</div>

<style type="scss">
    .db-nav-bar {
        padding: 10px;
        background-color: bisque;
    }
</style>
