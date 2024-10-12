using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(80, MinimumLength = 1, ErrorMessage = "Product name must be between 1 and 80 characters")]
        public string Name { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Product price is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than 0")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Price must be a valid number")]
        public int Price { get; set; }

        [DisplayName("Stock")]
        [Required(ErrorMessage = "Stock is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock must be 0 or more")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Stock must be a valid number")]
        public int Stock { get; set; }

        [DisplayName("Category Id")]
        [Required(ErrorMessage = "Category ID is required")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Category ID must be a valid number")]
        public int CategoryId { get; set; }
    }

}
