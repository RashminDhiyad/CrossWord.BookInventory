﻿using CrossWord.BookInventory.MultiLingualObjects;
using System;
using Volo.Abp.Application.Dtos;

namespace CrossWord.BookInventory.Books
{
    public class BookDto : AuditedEntityDto<Guid>, IObjectTranslation
    {
        public Guid AuthorId { get; set; }

        public string AuthorName { get; set; }

        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }

        public string Language { get; set; }
    }
}
