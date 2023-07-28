using System;

namespace Qa5459.Entities;

public class ChildEntityCreateDto
{
    public Guid ParentId { get; set; }

    public string? Name { get; set; }
}
