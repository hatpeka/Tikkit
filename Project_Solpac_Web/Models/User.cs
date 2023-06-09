using System.ComponentModel.DataAnnotations;

namespace Project_Solpac_Web.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        ///[Required(ErrorMessage = "Email is required")]
        //[EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }

        //[Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        //[Required(ErrorMessage = "Phone number is required")]
        //[RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must have 10 digits")]
        public string? Phone { get; set; }
    }
}
