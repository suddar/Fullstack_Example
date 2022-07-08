export class Messenger {

    static listeners: MessageObject[] = [];
    static call(key: string, ...args) {
        this.get(key)?.value.call(args[0]);
    }

    static apply(key: string, ...args) {
        this.get(key)?.value.apply(args[0]);
    }

    static get(key: string) {
        return this.listeners.find(x => x.key === key);
    }

    static add(componentName: string, callBack: Function) {
        this.listeners.push(new MessageObject(componentName + '.' + callBack.name, callBack));
    }

    static remove(key: string) {
        for (let i = 0; i < this.listeners.length; i++) {
            const msg = this.listeners[i];
            if (msg.key === key) {
                this.listeners.splice(i, 1);
                return true;
            }
        }
        return false;
    }
}

class MessageObject {
    key: string;
    value: Function;
    constructor(key: string, value: Function) {
        this.key = key;
        this.value = value;
    }
}