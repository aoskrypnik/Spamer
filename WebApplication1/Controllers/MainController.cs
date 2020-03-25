using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("/")]
    public class MainController : Controller
    {
        private static readonly string ConnectionString = Environment.GetEnvironmentVariable("connection_string");

        private static readonly DbContextOptions<MyWebApiContext> DbContextOptions =
            new DbContextOptionsBuilder<MyWebApiContext>().UseNpgsql(ConnectionString).Options;
        
        [HttpGet]
        public IActionResult Get()
        {
            var db = new MyWebApiContext(DbContextOptions);
            ViewBag.Users = db.Users.ToList();
            ViewBag.Departments = db.Departments.ToList();
            return View();
        }

        [HttpPost]
        [Route("/save")]
        public IActionResult Post(User user)
        {
            var db = new MyWebApiContext(DbContextOptions);
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectPermanent("/");
        }

        [HttpPost]
        [Route("/update")]
        public IActionResult Put(User user)
        {
            var db = new MyWebApiContext(DbContextOptions);
            var foundUser = db.Users.FirstOrDefault(us => us.Id == user.Id);
            if (foundUser != null)
            {
                foundUser.Name = user.Name;
                foundUser.DepartmentId = user.DepartmentId;
                foundUser.Position = user.Position;
                foundUser.Salary = user.Salary;
                db.Entry(foundUser).State = EntityState.Modified;
            }

            db.SaveChanges();
            return RedirectPermanent("/");
        }

        [HttpPost]
        [Route("/delete")]
        public IActionResult Delete(UserDto userDto)
        {
            var db = new MyWebApiContext(DbContextOptions);
            var user = new User {Id = userDto.Id};
            db.Users.Attach(user);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectPermanent("/");
        }
    }

    public class UserDto
    {
        public int Id { get; set; }
    }
}