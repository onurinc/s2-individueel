using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PlannerWebApplicationV2.Models
{
    [Keyless]
    public class BugReportModel
    {
        [Required(ErrorMessage = "Please enter your E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please provide the subject of the issue")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please provide some information about the issue")]
        [Display(Name = "Provide information about the problem here")]
        [StringLength(500, ErrorMessage = "You can only use 500 characters to provide the information")]
        [MaxLength(500)]
        public string Body { get; set; }

    }
}
