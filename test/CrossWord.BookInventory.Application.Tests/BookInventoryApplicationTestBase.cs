using Volo.Abp.Modularity;

namespace CrossWord.BookInventory;

public abstract class BookInventoryApplicationTestBase<TStartupModule> : BookInventoryTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
