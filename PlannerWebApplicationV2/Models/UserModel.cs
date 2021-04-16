using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PlannerWebApplicationV2.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please enter a User Name")]
        public string Username { get; set; }

        [Display(Name = "E-Mail")]
        [Required(ErrorMessage = "Must be a valid email address")]
        [DataType((DataType.EmailAddress))]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter a Password")]
        [DataType((DataType.Password))]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Passwords don't match")]
        [DataType((DataType.Password))]
        public string ConfirmPassword { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your First Name")]
        public string Firstname { get; set; }

        [Display(Name = "Middlename")]
        public string Middlename { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your Last Name")]
        public string Lastname { get; set; }



    }
}
