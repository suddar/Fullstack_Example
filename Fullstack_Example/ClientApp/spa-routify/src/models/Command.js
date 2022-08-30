export class Command {
    commandName;
    requestData;
}

export const CommandName = {
    //#region topic
    TOPIC_CREATE: 0,
    TOPIC_GET_MULTI: 1,
    TOPIC_GET_BY_ID: 2,
    TOPIC_UPDATE: 3,
    TOPIC_DELETE: 4
    //#endregion
}