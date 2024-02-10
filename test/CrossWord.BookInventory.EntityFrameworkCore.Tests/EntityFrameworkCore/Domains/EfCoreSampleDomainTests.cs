using CrossWord.BookInventory.Samples;
using Xunit;

namespace CrossWord.BookInventory.EntityFrameworkCore.Domains;

//[Collection(BookInventoryTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookInventoryEntityFrameworkCoreTestModule>
{

}
