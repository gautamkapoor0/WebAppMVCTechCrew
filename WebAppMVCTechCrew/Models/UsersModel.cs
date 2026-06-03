using System.ComponentModel.DataAnnotations;

namespace WebAppMVCTechCrew.Models
{
    public class UsersModel
    {
        [Key]  // pk and auto gene
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
    }
}
