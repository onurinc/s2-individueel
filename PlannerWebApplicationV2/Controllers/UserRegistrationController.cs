using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using PlannerWebApplicationV2.HelperClasses;
using PlannerWebApplicationV2.Models;

namespace PlannerWebApplicationV2.Controllers
{
    public class UserRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(IFormCollection formCollection)
        {
            if (ModelState.IsValid)
            {
                UserModel user = new UserModel()
                {
                    Username = formCollection["Username"],
                    Email = formCollection["Email"],
                    Password = formCollection["Password"],
                    Firstname = formCollection["Username"],
                    Middlename = formCollection["Middlename"],
                    Lastname = formCollection["Lastname"],
                };
                UserRegistrationClass.UserRegistration(user);
                ViewData["Message"] = "User " + user.Username + " has been registered successfully";
            }
            return View("Create");
        }
    }
}
