using System.ComponentModel.DataAnnotations;

namespace WebAppMVCTechCrew.Models
{
    public class ProductsModel
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
 
    }
}
