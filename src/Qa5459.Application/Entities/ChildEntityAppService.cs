using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Qa5459.Entities;

public class ChildEntityAppService : CrudAppService<
    ChildEntity,
    ChildEntityDto,
    Guid,
    PagedAndSortedResultRequestDto,
    ChildEntityCreateDto,
    ChildEntityUpdateDto>
{
    public ChildEntityAppService(IRepository<ChildEntity, Guid> repository) : base(repository)
    {
    }
}
