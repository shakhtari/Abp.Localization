using System.Threading.Tasks;

namespace ML.Data;

public interface IMLDbSchemaMigrator
{
    Task MigrateAsync();
}
