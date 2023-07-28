using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.Domain.Repositories;

namespace Qa5459.Entities;

public class EntityDataSeeder : IDataSeedContributor
{
    private readonly IRepository<ParentEntity, Guid> _parentEntityRepository;

    public EntityDataSeeder(IRepository<ParentEntity, Guid> parentEntityRepository)
    {
        _parentEntityRepository = parentEntityRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _parentEntityRepository.AnyAsync())
        {
            return;
        }

        ParentEntity entity = new()
        {
            Name = "Sample parent",
            Children = new List<ChildEntity>()
            {
                new ChildEntity()
                {
                    Name = "Child 1",
                },
                new ChildEntity()
                {
                    Name = "Child 2"
                }
            }
        };

        await _parentEntityRepository.InsertAsync(entity);
    }
}
