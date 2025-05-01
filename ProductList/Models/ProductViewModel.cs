using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductList.Models
{
    public class ProductViewModel

    {
        [Required]
        [StringLength(10, ErrorMessage = "Serial number cannot exceed 10 digits.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Serial number must be numeric.")]
        public string Serial { get; set; }

        public int SelectedSupplierId { get; set; }
        public int SelectedCategoryId { get; set; }
        public int SelectedProductId { get; set; }
        public List<Category> Categories { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<Product> Products { get; set; }
    }
}