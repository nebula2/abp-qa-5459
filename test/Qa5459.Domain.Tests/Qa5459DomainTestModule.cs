using Qa5459.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Qa5459;

[DependsOn(
    typeof(Qa5459EntityFrameworkCoreTestModule)
    )]
public class Qa5459DomainTestModule : AbpModule
{

}
