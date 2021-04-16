using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerWebApplicationV2.Models
{
    public class UserLoginModel
    {
        [Key]
        public string UserId { get; set; }


        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please enter a User Name")]
        public string Username { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter a Password")]
        [DataType((DataType.Password))]
        public string Password { get; set; }
    }
}
