using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlannerWebApplicationV2.Models;
using System.Net.Mail;

namespace PlannerWebApplicationV2.Data
{
    public class BugReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BugReportModel bugReport)
        {
            string email = bugReport.Email;
            string subject = bugReport.Subject;
            string body = bugReport.Body;

            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(email);
            mailMessage.Subject = subject;
            mailMessage.From = new MailAddress("db3b3cdf8c-c3e97c@inbox.mailtrap.io");
            mailMessage.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient("smtp.mailtrap.io");
            smtp.Port = 2525;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("ad3f4fd6510412", "948abe13d2a8e6");
            smtp.Send(mailMessage);
            ViewBag.message = "Thanks for reporting the bug. The mail has been sent to " + mailMessage.To;

            return View();
        }
    }
}
