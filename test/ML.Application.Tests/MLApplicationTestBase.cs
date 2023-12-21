using Volo.Abp.Modularity;

namespace ML;

public abstract class MLApplicationTestBase<TStartupModule> : MLTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
