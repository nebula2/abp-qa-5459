using Qa5459.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qa5459.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Qa5459Controller : AbpControllerBase
{
    protected Qa5459Controller()
    {
        LocalizationResource = typeof(Qa5459Resource);
    }
}
