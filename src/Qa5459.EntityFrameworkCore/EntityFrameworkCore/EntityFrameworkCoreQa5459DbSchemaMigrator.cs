using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Qa5459.Data;
using Volo.Abp.DependencyInjection;

namespace Qa5459.EntityFrameworkCore;

public class EntityFrameworkCoreQa5459DbSchemaMigrator
    : IQa5459DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreQa5459DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Qa5459DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Qa5459DbContext>()
            .Database
            .MigrateAsync();
    }
}
