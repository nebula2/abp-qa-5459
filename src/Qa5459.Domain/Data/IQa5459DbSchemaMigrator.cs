using System.Threading.Tasks;

namespace Qa5459.Data;

public interface IQa5459DbSchemaMigrator
{
    Task MigrateAsync();
}
