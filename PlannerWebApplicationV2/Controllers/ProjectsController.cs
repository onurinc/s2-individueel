using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlannerWebApplicationV2.Data;
using PlannerWebApplicationV2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace PlannerWebApplicationV2.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ProjectsDataContext context;

        public ProjectsController(ProjectsDataContext context)
        {
            this.context = context;
        }

        // GET / 
        public async Task<ActionResult> Index()
        {
            IQueryable<ProjectsTable> items = from i in context.Projects orderby i.Id select i;
            List<ProjectsTable> Projects = await items.ToListAsync();

            return View(Projects);
        }

        // GET /project/create
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Create(ProjectsTable item)
        {
            if (ModelState.IsValid)
            {
                context.Add(item);
                await context.SaveChangesAsync();

                TempData["Success"] = "The project has been added";

                return RedirectToAction("Index");
            }
            return View(item);
        }

        //GET /project/edit/id
        public async Task<ActionResult> Edit(int id)
        {
            ProjectsTable item = await context.Projects.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ProjectsTable item)
        {
            if (ModelState.IsValid)
            {
                context.Update(item);
                await context.SaveChangesAsync();

                TempData["Success"] = "The project has been updated";

                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET /project/delete/id
        public async Task<ActionResult> Delete(int id)
        {
            ProjectsTable item = await context.Projects.FindAsync(id);
            if (item == null)
            {
                TempData["Error"] = "The project doesn't exist";
            }
            else
            {
                context.Projects.Remove(item);
                await context.SaveChangesAsync();
                TempData["Success"] = "The project has been deleted";
            }
            return RedirectToAction("Index");
        }
    }
}
