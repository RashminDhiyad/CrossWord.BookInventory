using System;
using System.Collections.Generic;
using System.Text;
using CrossWord.BookInventory.Localization;
using Volo.Abp.Application.Services;

namespace CrossWord.BookInventory;

/* Inherit your application services from this class.
 */
public abstract class BookInventoryAppService : ApplicationService
{
    protected BookInventoryAppService()
    {
        LocalizationResource = typeof(BookInventoryResource);
    }
}
