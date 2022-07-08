<script lang="ts">
    import { Messenger } from "../../../lib/messenger";

    export let icon: string;
    export let text: string;
    export let componentName: string;

    function message() {
        Messenger.call("Dashboard.switchComponent", {
            text: text,
            componentName: componentName,
        });
    }
</script>

<span on:click={() => message()} style="font-size: 1em; color: darkcyan;">
    <i class={icon} />
    {text}
</span>
