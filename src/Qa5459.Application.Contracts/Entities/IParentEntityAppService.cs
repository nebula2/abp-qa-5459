using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Qa5459.Entities;

public interface IParentEntityAppService : ICrudAppService<
    ParentEntityDto,
    Guid,
    PagedAndSortedResultRequestDto,
    ParentEntityCreateUpdateDto>
{
    public Task DeleteWithConstraintAsync(Guid id);
}
