using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmailController : Controller
    {
        private static readonly string ConnectionString = Environment.GetEnvironmentVariable("connection_string");

        private static readonly DbContextOptions<MyWebApiContext> DbContextOptions =
            new DbContextOptionsBuilder<MyWebApiContext>().UseNpgsql(ConnectionString).Options;

        [HttpGet]
        [Route("/mail")]
        public IActionResult Get()
        {
            var db = new MyWebApiContext(DbContextOptions);
            ViewBag.Messages = db.Messages.ToList();
            ViewBag.Departments = db.Departments.ToList();
            return View();
        }

        [HttpPost]
        [Route("/send")]
        public IActionResult Post(EmailDto emailDto)
        {
            var db = new MyWebApiContext(DbContextOptions);

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(Environment.GetEnvironmentVariable("email_name"),
                Environment.GetEnvironmentVariable("email_pass"));
            smtp.EnableSsl = true;

            if (emailDto.Department == 0)
            {
                List<User> users = db.Users.ToList();
                SendEmailToEachUser(emailDto, users, smtp);
            }
            else
            {
                List<User> users = db.Users.ToList().Where(u => u.DepartmentId == emailDto.Department).ToList();
                SendEmailToEachUser(emailDto, users, smtp);
            }

            if (emailDto.Radio.Equals("yes"))
            {
                Message message = new Message();
                message.Subject = emailDto.Subject;
                message.Text = emailDto.Text;
                db.Messages.Add(message);
                db.SaveChanges();
            }

            return RedirectPermanent("/mail");
        }

        private static void SendEmailToEachUser(EmailDto emailDto, List<User> users, SmtpClient smtp)
        {
            foreach (var user in users)
            {
                MailAddress from = new MailAddress("andreus.sao@gmail.com", "Internal mail");
                MailAddress to = new MailAddress(user.Email);
                MailMessage m = new MailMessage(@from, to);
                m.Subject = emailDto.Subject;
                m.Body = emailDto.Text;
                smtp.Send(m);
            }
        }
    }

    public class EmailDto
    {
        public string Subject { get; set; }
        public string Text { get; set; }
        public string Radio { get; set; }
        public int Department { get; set; }
    }
}