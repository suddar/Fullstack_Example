import type { Course } from './Course';
export class Topic {
    id: number;
    name: string;
    courses: Course[]

    constructor(name: string, id: number = 0) {
        this.name = name;
        this.id = id;
    }
}