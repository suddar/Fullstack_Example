//import adapter from '@sveltejs/adapter-auto';
// Replace the original `adapter-auto` line with this in svelte.config.js
import adapter from '@sveltejs/adapter-static'

import preprocess from 'svelte-preprocess';

/** @type {import('@sveltejs/kit').Config} */
const config = {
	// Consult https://github.com/sveltejs/svelte-preprocess
	// for more information about preprocessors
	preprocess: preprocess(),

	kit: {
		adapter: adapter(),
		prerender: {
			default: true
		},
	}
};

export default config;
