using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Qa5459.Entities;

public class ParentEntity : Entity<Guid>
{
    public string? Name { get; set; }

    public ICollection<ChildEntity>? Children { get; set; }
}
