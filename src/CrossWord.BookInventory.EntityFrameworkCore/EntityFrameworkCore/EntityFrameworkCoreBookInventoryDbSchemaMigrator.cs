using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CrossWord.BookInventory.Data;
using Volo.Abp.DependencyInjection;

namespace CrossWord.BookInventory.EntityFrameworkCore;

public class EntityFrameworkCoreBookInventoryDbSchemaMigrator
    : IBookInventoryDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookInventoryDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the BookInventoryDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookInventoryDbContext>()
            .Database
            .MigrateAsync();
    }
}
