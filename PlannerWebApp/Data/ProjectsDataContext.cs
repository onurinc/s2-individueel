using Microsoft.EntityFrameworkCore;
using PlannerWebApp.Models;

namespace PlannerWebApp.Data
{
    public class ProjectsDataContext : DbContext
    {
        public ProjectsDataContext(DbContextOptions<ProjectsDataContext> options)
            : base(options)
        {

        }

        public DbSet<Projects> Projects { get; set; }


    }
}
