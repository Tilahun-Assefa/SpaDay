using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{

    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password ==verify)
            {
                User user = new User(newUser.Username, newUser.Email, newUser.Password);
                ViewBag.user = user;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Verify the password";
                ViewBag.name = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");
            }

        }

    }
}
