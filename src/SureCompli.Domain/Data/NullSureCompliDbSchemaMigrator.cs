using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SureCompli.Data
{
    /* This is used if database provider does't define
     * ISureCompliDbSchemaMigrator implementation.
     */
    public class NullSureCompliDbSchemaMigrator : ISureCompliDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}