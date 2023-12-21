using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ML.Blazor;

[Dependency(ReplaceServices = true)]
public class MLBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ML";
}
