using CrossWord.BookInventory.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CrossWord.BookInventory.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookInventoryController : AbpControllerBase
{
    protected BookInventoryController()
    {
        LocalizationResource = typeof(BookInventoryResource);
    }
}
