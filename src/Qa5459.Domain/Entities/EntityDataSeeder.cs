using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Qa5459.Entities;

public class EntityDataSeeder : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<ParentEntity, Guid> _parentEntityRepository;
    private readonly IRepository<ChildEntity, Guid> _childEntityRepository;
    private readonly ILogger<EntityDataSeeder> _logger;

    public EntityDataSeeder(
        IRepository<ParentEntity, Guid> parentEntityRepository,
        ILogger<EntityDataSeeder> logger,
        IRepository<ChildEntity, Guid> childEntityRepository)
    {
        _parentEntityRepository = parentEntityRepository;
        _logger = logger;
        _childEntityRepository = childEntityRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        //if (await _parentEntityRepository.AnyAsync())
        //{
        //    return;
        //}

        ParentEntity entity = new()
        {
            Name = "Sample parent",
        };

        await _parentEntityRepository.InsertAsync(entity, autoSave: true);

        ChildEntity childEntity = new()
        {
            Name = "Sample child",
            ParentEntityId = entity.Id,
        };

        await _childEntityRepository.InsertAsync(childEntity, autoSave: true);

        _logger.LogInformation("Seeded entities");
    }
}
