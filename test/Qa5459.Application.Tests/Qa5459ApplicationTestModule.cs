using Volo.Abp.Modularity;

namespace Qa5459;

[DependsOn(
    typeof(Qa5459ApplicationModule),
    typeof(Qa5459DomainTestModule)
    )]
public class Qa5459ApplicationTestModule : AbpModule
{

}
