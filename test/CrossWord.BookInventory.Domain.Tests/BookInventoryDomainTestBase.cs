using Volo.Abp.Modularity;

namespace CrossWord.BookInventory;

/* Inherit from this class for your domain layer tests. */
public abstract class BookInventoryDomainTestBase<TStartupModule> : BookInventoryTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
