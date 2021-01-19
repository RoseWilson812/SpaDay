using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Must be 5-15 characters long")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Must be 6-20 characters long")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Verify Password is required.")]
        [Compare("Password", ErrorMessage = "Does not match Password")]
        public string VerifyPassword { get; set; }

        
    }
}
