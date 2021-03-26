using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlannerWebApplicationV2.Models;

namespace PlannerWebApplicationV2.Data
{
    public class ProjectsDataContext : DbContext
    {
        public ProjectsDataContext(DbContextOptions<ProjectsDataContext> options)
            : base(options)
        {

        }

        public DbSet<ProjectsTable> Projects { get; set; }
    }
}
