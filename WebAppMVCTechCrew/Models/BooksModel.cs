using System.ComponentModel.DataAnnotations;

namespace WebAppMVCTechCrew.Models
{
    public class BooksModel
    {
        [Key]
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}
