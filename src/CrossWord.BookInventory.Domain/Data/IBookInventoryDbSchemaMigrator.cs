using System.Threading.Tasks;

namespace CrossWord.BookInventory.Data;

public interface IBookInventoryDbSchemaMigrator
{
    Task MigrateAsync();
}
