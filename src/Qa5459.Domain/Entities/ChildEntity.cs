using System;
using Volo.Abp.Domain.Entities;

namespace Qa5459.Entities;

public class ChildEntity : Entity<Guid>
{
    public Guid ParentEntityId { get; set; }

    public string? Name { get; set; }
}
