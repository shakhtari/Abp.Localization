using Volo.Abp.Modularity;

namespace ML;

[DependsOn(
    typeof(MLApplicationModule),
    typeof(MLDomainTestModule)
)]
public class MLApplicationTestModule : AbpModule
{

}
