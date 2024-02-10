using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CrossWord.BookInventory.Pages;

public class Index_Tests : BookInventoryWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
