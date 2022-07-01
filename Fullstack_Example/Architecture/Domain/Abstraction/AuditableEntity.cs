﻿namespace Fullstack_Example.Architecture.Domain.Abstraction
{
    public abstract class AuditableEntity:BaseEntity
    {
        public DateTime Created { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? LastModified { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}
