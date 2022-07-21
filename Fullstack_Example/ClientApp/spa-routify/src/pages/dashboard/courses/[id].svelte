<script>
    export let id;
    
</script>

<h1>{id}</h1>

<ul>
    {#each topics as topic}
        <li>
            <a href={$url("/dashboard/courses/:id",{id:topic.id})}> {topic.name}</a>
            <a
                href={$url("/dashboard/topics/edit-topic/:id", {
                    id: topic.id,
                })}
            >
                <i class="fa-solid fa-pen-to-square" />
            </a>
            <span on:click={() => removeTopic(topic.id)}>
                <i style="cursor:pointer ;" class="fa-solid fa-xmark" />
            </span>
        </li>
    {/each}
</ul>