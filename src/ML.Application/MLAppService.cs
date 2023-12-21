using System;
using System.Collections.Generic;
using System.Text;
using ML.Localization;
using Volo.Abp.Application.Services;

namespace ML;

/* Inherit your application services from this class.
 */
public abstract class MLAppService : ApplicationService
{
    protected MLAppService()
    {
        LocalizationResource = typeof(MLResource);
    }
}
