using Volo.Abp.Modularity;

namespace ML;

/* Inherit from this class for your domain layer tests. */
public abstract class MLDomainTestBase<TStartupModule> : MLTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
