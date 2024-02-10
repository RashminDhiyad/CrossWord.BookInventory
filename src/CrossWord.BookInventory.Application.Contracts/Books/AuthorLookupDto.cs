using System;
using Volo.Abp.Application.Dtos;

namespace CrossWord.BookInventory.Books
{
    public class AuthorLookupDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
