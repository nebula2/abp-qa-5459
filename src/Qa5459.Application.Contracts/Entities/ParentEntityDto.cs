using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Qa5459.Entities;

public class ParentEntityDto : EntityDto<Guid>
{
    public string? Name { get; set; }

    public List<ChildEntityDto>? Children { get; set; }
}
