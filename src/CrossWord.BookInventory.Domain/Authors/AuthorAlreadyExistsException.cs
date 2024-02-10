using Volo.Abp;

namespace CrossWord.BookInventory.Authors
{
    public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name)
            : base(BookInventoryDomainErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
