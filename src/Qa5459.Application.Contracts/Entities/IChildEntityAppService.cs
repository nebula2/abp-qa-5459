using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Qa5459.Entities;

public interface IChildEntityAppService : ICrudAppService<
    ChildEntityDto,
    Guid,
    PagedAndSortedResultRequestDto,
    ChildEntityCreateDto,
    ChildEntityUpdateDto>
{
}
