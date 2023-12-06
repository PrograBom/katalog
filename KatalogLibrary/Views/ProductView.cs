using KatalogLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatalogLibrary.Views
{
    public class ProductView
    {
        public ProductView() { }
        public ProductView(Product product)
        {
            Id = product.Id;
            Title = product.Title;
            ISBN = product.ISBN;
            Price = Math.Round((decimal)product.Price, 2);
            Description = product.Description;
            AvailableQuantity = product.AvailableQuantity;
            PublicationDate = product.PublicationDate;
            Authors = product.Author.Name;
            CategoryName = product.Category.CategoryName;
        }
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public int AvailableQuantity { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Authors { get; set; }
        public string CategoryName { get; set; }
    }
}
