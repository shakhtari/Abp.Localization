using ML.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ML.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MLEntityFrameworkCoreModule),
    typeof(MLApplicationContractsModule)
    )]
public class MLDbMigratorModule : AbpModule
{
}
