using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CrossWord.BookInventory.Data;

/* This is used if database provider does't define
 * IBookInventoryDbSchemaMigrator implementation.
 */
public class NullBookInventoryDbSchemaMigrator : IBookInventoryDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
