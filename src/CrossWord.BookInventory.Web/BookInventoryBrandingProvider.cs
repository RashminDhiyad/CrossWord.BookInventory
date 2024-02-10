using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CrossWord.BookInventory.Web;

[Dependency(ReplaceServices = true)]
public class BookInventoryBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookInventory";
}
