using Microsoft.AspNetCore.Builder;
using CrossWord.BookInventory;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<BookInventoryWebTestModule>();

public partial class Program
{
}
