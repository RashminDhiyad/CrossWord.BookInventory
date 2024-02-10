using Volo.Abp.Modularity;

namespace CrossWord.BookInventory;

[DependsOn(
    typeof(BookInventoryApplicationModule),
    typeof(BookInventoryDomainTestModule)
)]
public class BookInventoryApplicationTestModule : AbpModule
{

}
