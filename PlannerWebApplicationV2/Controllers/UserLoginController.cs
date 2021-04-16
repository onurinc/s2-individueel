using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlannerWebApplicationV2.Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;

namespace PlannerWebApplicationV2.Controllers
{
    public class UserLoginController : Controller
    {
        public string connectionstring =
            @"Data Source=DESKTOP-A6O4P0A\SQLEXPRESS;Initial Catalog=Projects;Integrated Security=True";
        // GET

        [HttpGet]
        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(UserLoginModel userLogin)
        {
            using SqlConnection sqlconn = new SqlConnection(connectionstring);
            {
                sqlconn.Open();
                string sqlquery =
                    "select Username, Password from [dbo].[User] where Username = @Username and Password = @Password";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlcomm.Parameters.AddWithValue("@Username", userLogin.Username);
                sqlcomm.Parameters.AddWithValue("@Password", userLogin.Password);
                SqlDataReader sdr = sqlcomm.ExecuteReader();
                if (sdr.Read())
                {
                    TempData["Success"] = "User logged in successfully";
                    //TODO: Logedinuserclass met id / model opslaan in de class
                }
                else
                {
                    TempData["Error"] = "User login details failed";
                }
                sqlconn.Close();
            }
            return View(userLogin);
        }
    }
}
