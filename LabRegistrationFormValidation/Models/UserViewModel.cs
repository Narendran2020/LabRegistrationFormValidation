using LabRegistrationFormValidation.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LabRegistrationFormValidation.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Email")]
        [EmailAddress(ErrorMessage = "Please enter Correct EmailId")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please enter Password")]

        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",
         ErrorMessage = "Password required (1 Uppercase, 1 Number, 1 Special Char and 1 Lowercase Char) with Min Length 8 Chars")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm Password doesn't match")]
        [Required(ErrorMessage = "Please enter Confirm Password")]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"^[9187]\d{9}$", ErrorMessage = "Please enter correct Mobile Number")]
        public string? Contact { get; set; }


        [Required(ErrorMessage = "Gender is Required")]
        public string Gender { get; set; }

        [ValidateCheckBox(ErrorMessage ="Please accept Terms")]
        public bool Terms { get; set; }
    }
}
