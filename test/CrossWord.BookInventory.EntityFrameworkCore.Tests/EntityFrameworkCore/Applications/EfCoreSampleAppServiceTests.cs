using CrossWord.BookInventory.Samples;
using Xunit;

namespace CrossWord.BookInventory.EntityFrameworkCore.Applications;

//[Collection(BookInventoryTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookInventoryEntityFrameworkCoreTestModule>
{

}
