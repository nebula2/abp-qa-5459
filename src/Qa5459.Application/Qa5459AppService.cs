using System;
using System.Collections.Generic;
using System.Text;
using Qa5459.Localization;
using Volo.Abp.Application.Services;

namespace Qa5459;

/* Inherit your application services from this class.
 */
public abstract class Qa5459AppService : ApplicationService
{
    protected Qa5459AppService()
    {
        LocalizationResource = typeof(Qa5459Resource);
    }
}
