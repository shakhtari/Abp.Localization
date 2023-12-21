using Volo.Abp.Settings;

namespace ML.Settings;

public class MLSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MLSettings.MySetting1));
    }
}
