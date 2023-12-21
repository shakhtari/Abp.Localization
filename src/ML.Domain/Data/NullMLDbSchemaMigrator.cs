using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ML.Data;

/* This is used if database provider does't define
 * IMLDbSchemaMigrator implementation.
 */
public class NullMLDbSchemaMigrator : IMLDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
