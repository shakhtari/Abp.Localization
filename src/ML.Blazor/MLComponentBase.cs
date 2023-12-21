using ML.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ML.Blazor;

public abstract class MLComponentBase : AbpComponentBase
{
    protected MLComponentBase()
    {
        LocalizationResource = typeof(MLResource);
    }
}
