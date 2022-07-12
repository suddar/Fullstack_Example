<script>
    import SideMenu from "./components/SideMenu.svelte";
    let pageContent;
    let props;
</script>

<p>DASHBOARD PAGE</p>
<SideMenu />
<div class="db-page-content">
    <svelte:component this={pageContent} {...props} />
</div>
