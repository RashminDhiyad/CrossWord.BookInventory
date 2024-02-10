using AutoMapper;
using CrossWord.BookInventory.Authors;
using CrossWord.BookInventory.Books;
using CrossWord.BookInventory.Web.Pages.Books;

namespace CrossWord.BookInventory.Web;

public class BookInventoryWebAutoMapperProfile : Profile
{
    public BookInventoryWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<BookDto, CreateUpdateBookDto>();

        CreateMap<Pages.Authors.CreateModalModel.CreateAuthorViewModel, CreateAuthorDto>();

        CreateMap<AuthorDto, Pages.Authors.EditModalModel.EditAuthorViewModel>();
        CreateMap<Pages.Authors.EditModalModel.EditAuthorViewModel, UpdateAuthorDto>();

        CreateMap<Pages.Books.CreateModalModel.CreateBookViewModel, CreateUpdateBookDto>();
        CreateMap<BookDto, Pages.Books.EditModalModel.EditBookViewModel>();
        CreateMap<Pages.Books.EditModalModel.EditBookViewModel, CreateUpdateBookDto>();

        CreateMap<AddTranslationModal.BookTranslationViewModel, AddBookTranslationDto>();
    }
}
