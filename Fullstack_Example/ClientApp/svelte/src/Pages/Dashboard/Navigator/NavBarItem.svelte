<script lang="ts">
    import { Messenger } from "../../../lib/messenger";

    export let icon: string;
    export let text: string;

    function message(text) {
        Messenger.call("Dashboard.switchComponent", { text: text });
    }
</script>

<span
    on:click={() => message({ text })}
    style="font-size: 1em; color: darkcyan;"
>
    <i class={icon} />
    {text}
</span>
