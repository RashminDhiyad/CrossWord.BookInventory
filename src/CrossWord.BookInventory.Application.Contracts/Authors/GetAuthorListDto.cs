using Volo.Abp.Application.Dtos;

namespace CrossWord.BookInventory.Authors
{
    public class GetAuthorListDto : PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
    }
}
