using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace Qa5459.Entities;

public class ParentEntityAppService : CrudAppService<
    ParentEntity,
    ParentEntityDto,
    Guid,
    PagedAndSortedResultRequestDto,
    ParentEntityCreateUpdateDto>, IParentEntityAppService
{

    public ParentEntityAppService(IRepository<ParentEntity, Guid> repository) : base(repository)
    {
    }

    public override async Task DeleteAsync(Guid id)
    {
        var parent = await Repository.GetAsync(id: id, includeDetails: true);

        if (parent.Children != null &&
            parent.Children.Any())
        {
            throw new UserFriendlyException("Cannot delete parent as there are Children");
        }

        await base.DeleteAsync(id);
    }

    [UnitOfWork(IsDisabled = true)]
    public async Task DeleteWithConstraintAsync(Guid id)
    {
        try
        {
            await Repository.DeleteAsync(id, autoSave: true);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            Debugger.Break();
        }
    }
}
