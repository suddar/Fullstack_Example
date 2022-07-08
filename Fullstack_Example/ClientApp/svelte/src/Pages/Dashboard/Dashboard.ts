import { Messenger } from "../../lib/messenger";
import UserPanel from "./UserPanel/UserPanel.svelte";

export function _switchComponent() {
    console.log(this.text);
}

// Messenger.add("Dashboard", switchComponent);

// export var component: any = UserPanel;
// export let props: any;