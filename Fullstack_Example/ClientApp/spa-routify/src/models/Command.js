export class Command {
    name;
    requestData;
}

export const CommandNames = {
    //#region topic commands
    CreateTopic: "CreateTopic",
    GetTopicById: "GetTopicById",
    GetTopics: "GetTopics",
    UpdateTopic: "UpdateTopic",
    DeleteTopic: "DeleteTopic",
    //#endregion

    //#region course commands
    CreateCourse: "CreateCourse",
    GetCourseById: "GetCourseById",
    GetCourses: 'GetCourses',
    UpdateCourse: "UpdateCourse",
    DeleteCourse: "DeleteCourse"
    //#endregion
}
