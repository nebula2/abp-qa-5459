using System;
using Volo.Abp.Application.Dtos;

namespace Qa5459.Entities;

public class ChildEntityDto : EntityDto<Guid>
{
    public Guid ParentId { get; set; }
    public string? Name { get; set; }
}
