﻿using Fullstack_Example.Architecture.Application.Commands.Topics;
using Fullstack_Example.Architecture.Application.Commands.Users;

namespace Fullstack_Example.Architecture.Domain.Enums
{
    public enum CommandName
    {
        TOPIC_CREATE,
        TOPIC_GET_MULTI,
        TOPIC_GET_BY_ID,
        TOPIC_UPDATE,
        TOPIC_DELETE
    }

    public static class CommandNames
    {
        public const string CreateTopic = "CreateTopic";
        public const string GetTopicById = "GetTopicById";
        public const string GetTopics = "GetTopics";
        public const string UpdateTopic = "UpdateTopic";
        public const string DeleteTopic = "DeleteTopic";

        public const string CreateCourse = "CreateCourse";
        public const string GetCourseById = "GetCourseById";
        public const string GetCourses = "GetCourses";
        public const string UpdateCourse = "UpdateCourse";
        public const string DeleteCourse = "DeleteCourse";

        public const string UserLogin = "UserLogin";
        public const string UserRegister = "UserRegister";
    }
}
