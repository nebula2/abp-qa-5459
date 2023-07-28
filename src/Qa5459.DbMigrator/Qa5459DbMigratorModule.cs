using Qa5459.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Qa5459.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Qa5459EntityFrameworkCoreModule),
    typeof(Qa5459ApplicationContractsModule)
    )]
public class Qa5459DbMigratorModule : AbpModule
{
}
