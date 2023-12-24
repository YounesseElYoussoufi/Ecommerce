using Ecomproject.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace Ecomproject.Models
{
    public class Category : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        public String? CategoryName { get; set; }

        [Display(Name = "Category Logo")]
        public string? CategoryLogoURL { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        public List<Product>? Products { get; set; }


    }
}
