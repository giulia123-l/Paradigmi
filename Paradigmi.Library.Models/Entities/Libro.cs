using System;
using System.Collections.Generic;

namespace Paradigmi.Library.Models.Entities
{
    public class Book
    {
        public Book() { }

        public Book(string name, string author, DateTime publicationDate, string editor, HashSet<Category> categories)
        {
            Name = name;
            Author = author;
            PublicationDate = publicationDate;
            Editor = editor;
            Categories = categories ?? new HashSet<Category>();
        }

        public int IdBook { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime PublicationDate { get; set; }
        public string Editor { get; set; } = string.Empty;
        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    }
}
