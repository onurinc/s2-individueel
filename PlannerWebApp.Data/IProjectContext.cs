using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerWebApp.Data
{
    interface IProjectContext
    { 
        IEnumerable<ProjectDTO> GetAllProjects();
       
        ProjectDTO  GetProjects(int id);

    }
}
