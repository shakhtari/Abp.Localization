using ML.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ML.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MLController : AbpControllerBase
{
    protected MLController()
    {
        LocalizationResource = typeof(MLResource);
    }
}
