using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        public int quantity { get; set; }
    }
}