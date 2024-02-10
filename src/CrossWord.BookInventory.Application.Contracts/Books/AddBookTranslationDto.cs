using CrossWord.BookInventory.MultiLingualObjects;
using System.ComponentModel.DataAnnotations;

namespace CrossWord.BookInventory.Books
{
    public class AddBookTranslationDto : IObjectTranslation
    {
        [Required]
        public string Language { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
