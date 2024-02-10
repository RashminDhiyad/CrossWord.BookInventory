using Volo.Abp.Modularity;

namespace CrossWord.BookInventory;

[DependsOn(
    typeof(BookInventoryDomainModule),
    typeof(BookInventoryTestBaseModule)
)]
public class BookInventoryDomainTestModule : AbpModule
{

}
