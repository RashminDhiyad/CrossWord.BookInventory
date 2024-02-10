using CrossWord.BookInventory.MultiLingualObjects;
using System;
using Volo.Abp.Domain.Entities;

namespace CrossWord.BookInventory.Books
{
    public class BookTranslation : Entity, IObjectTranslation
    {
        public Guid BookId { get; set; }

        public string Name { get; set; }

        public string Language { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { BookId, Language };
        }
    }
}
