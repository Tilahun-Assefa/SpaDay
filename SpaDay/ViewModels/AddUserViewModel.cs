using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage ="User name is required")]
        [StringLength(15, MinimumLength =5, ErrorMessage ="User name must be between 5 and 15 characters long.")]
        public string Username { get; set; }

        
        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Sorry, but the given password is too short. Passwords must be at least 6 characters long.")]
        [Compare("VerifyPassword", ErrorMessage = "Passwords do not match!")]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string VerifyPassword { get; set; }

    }
}
