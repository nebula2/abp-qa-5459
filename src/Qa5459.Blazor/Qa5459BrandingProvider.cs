using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Qa5459.Blazor;

[Dependency(ReplaceServices = true)]
public class Qa5459BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Qa5459";
}
