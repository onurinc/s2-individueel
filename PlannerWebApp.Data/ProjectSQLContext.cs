using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerWebApp.Data
{
    class ProjectSQLContext : IProjectContext
    {
        public IEnumerable<ProjectDTO> GetAllProjects()
        {
            throw new NotImplementedException();
        }

        public ProjectDTO GetProjects(int id)
        {
            throw new NotImplementedException();
        }
    }
}
