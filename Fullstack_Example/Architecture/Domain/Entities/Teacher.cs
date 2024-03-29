﻿using Fullstack_Example.Architecture.Domain.Interfaces;

namespace Fullstack_Example.Architecture.Domain.Entities
{
    public class Teacher : AuditableEntity, IPerson
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
