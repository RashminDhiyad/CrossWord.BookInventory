using AutoMapper;
using CrossWord.BookInventory.Authors;
using CrossWord.BookInventory.Books;

namespace CrossWord.BookInventory;

public class BookInventoryApplicationAutoMapperProfile : Profile
{
    public BookInventoryApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();

        CreateMap<Author, AuthorDto>();

        CreateMap<Author, AuthorLookupDto>();
    }
}
