using System.ComponentModel.DataAnnotations;

namespace WebAppMVCTechCrew.Models
{
    public class UsersModel
    {
        [Key]  // pk and auto gene
        public int ID { get; set; }
        [Required(ErrorMessage ="UserName Required")]  // null values 
        public string Username { get; set; }  // T when we have a value
        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Gender Required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Dob Required")]
        public DateTime Dob { get; set; }
    }
}
