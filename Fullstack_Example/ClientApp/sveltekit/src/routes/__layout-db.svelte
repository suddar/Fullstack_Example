<header>
	<nav>
		<a href="/">Home</a> |
		<a href="/dashboard">Dashboard</a> |
		<a href="/about">About</a>
	</nav>
</header>

<main>
	<div class="db-left-menu">
		<ul>
			<li><a href="/dashboard/users">Users</a></li>
			<li><a href="/dashboard/topics">Topics</a></li>
		</ul>
	</div>
	<slot />
</main>

<footer>this is footer</footer>

<style lang="scss">
	.db-left-menu {
		display: block;
		float: left;
		height: 600px;
		padding: 10px;
		background-color: beige;
		ul {
			padding: 0px;
			width: 50px;
			list-style-type: none;
		}
	}
</style>
