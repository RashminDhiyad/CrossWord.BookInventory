using CrossWord.BookInventory.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CrossWord.BookInventory.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookInventoryEntityFrameworkCoreModule),
    typeof(BookInventoryApplicationContractsModule)
    )]
public class BookInventoryDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
