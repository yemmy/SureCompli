using System.Threading.Tasks;

namespace SureCompli.Data
{
    public interface ISureCompliDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
