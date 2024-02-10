using CrossWord.BookInventory.MultiLingualObjects;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace CrossWord.BookInventory.Books
{
    public class Book : AuditedAggregateRoot<Guid>, IMultiLingualObject<BookTranslation>
    {
        public Guid AuthorId { get; set; }

        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }

        public ICollection<BookTranslation> Translations { get; set; }
    }
}
