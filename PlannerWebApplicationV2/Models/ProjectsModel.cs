using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerWebApplicationV2.Models
{
    public class ProjectsTable
    {
        public int Id { get; set; }
        [Required]
        public string ProjectName { get; set; }
    }
}
