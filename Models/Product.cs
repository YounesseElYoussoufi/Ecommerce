using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Ecomproject.Data.Enums;

namespace Ecomproject.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public String? ProductName { get; set; }
        public String? Description { get; set; }
        public string? ImageURL { get; set; }
        public double? Price { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public required Category Category { get; set; }
        public DateTime Date { get; set; }
       // public ProductCategory pCategory { get; set; }

    }
}
