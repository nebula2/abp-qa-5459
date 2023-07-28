using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Qa5459.Data;

/* This is used if database provider does't define
 * IQa5459DbSchemaMigrator implementation.
 */
public class NullQa5459DbSchemaMigrator : IQa5459DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
