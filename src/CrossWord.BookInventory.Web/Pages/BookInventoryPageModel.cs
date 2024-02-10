using CrossWord.BookInventory.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CrossWord.BookInventory.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BookInventoryPageModel : AbpPageModel
{
    protected BookInventoryPageModel()
    {
        LocalizationResourceType = typeof(BookInventoryResource);
    }
}
