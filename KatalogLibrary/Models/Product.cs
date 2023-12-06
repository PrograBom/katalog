using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatalogLibrary.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public int AvailableQuantity { get; set; }
        public DateTime PublicationDate { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public Category Category { get; set; } = new Category();
        public Author Author { get; set; } = new Author();
    }
}
