export class Course {
    id: number;
    topicId: number;
    name: string;

    constructor(name: string, topicId?: number, id: number = 0) {
        this.name = name;
        this.topicId = topicId ?? topicId;
        this.id = id;
    }
}