using Volo.Abp.Modularity;

namespace ML;

[DependsOn(
    typeof(MLDomainModule),
    typeof(MLTestBaseModule)
)]
public class MLDomainTestModule : AbpModule
{

}
