using Qa5459.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Qa5459.Blazor;

public abstract class Qa5459ComponentBase : AbpComponentBase
{
    protected Qa5459ComponentBase()
    {
        LocalizationResource = typeof(Qa5459Resource);
    }
}
