using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.DataAccess.ViewModels;
using PizzaApp.Services.Interfaces;

namespace PizzaApp.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserVM model)
        {
            //var usersDomain = StaticDB.ListOfUsers;

            //var loggedUser = usersDomain.SingleOrDefault(u => u.Email == model.Email && u.Password == model.Password);

            //if (loggedUser == null)
            //    return RedirectToAction("Register", new { error = "You are not registered, please register" });

            //if (loggedUser.isAdmin)
            //    return RedirectToAction("create", "pizzas");

            ////return RedirectToAction("list", "pizzas", "id");
            //return RedirectToAction("Index", "Store");

            var user = _userService.Login(model);

            if (user == true && model.isAdmin == false)
                return RedirectToAction("Index", "Store");

            if (user == true && model.isAdmin == true)
                return RedirectToAction("create", "pizzas");

            return RedirectToAction("Register", new { error = "You are not registered, please register" });

        }
        public IActionResult Register(string error)
        {
            ViewBag.Error = error;
            return View();
        }
        [HttpPost]
        public IActionResult RegisterNewUser(UserVM user)
        {
            //var usersDomain = StaticDB.ListOfUsers;

            //if (user.Email[0] >= 'a' && user.Email[0] <= 'z' &&
            //    user.Email[user.Email.Length - 1] >= 'a' && user.Email[user.Email.Length - 1] <= 'z' &&
            //    user.Email.Contains("@") &&
            //    user.Email.Contains("."))
            //{
            //    if (user.Password[0] >= 'A' && user.Password[0] <= 'Z' &&
            //    user.Password.Contains("$") &&
            //    user.Password.Any(char.IsDigit))
            //    {
            //        var existingEmailOrPass = usersDomain.SingleOrDefault(u => u.Email == user.Email || u.Password == user.Password);

            //        if (existingEmailOrPass != null)
            //            return RedirectToAction("Register", new { error = "Already existing email or password, please try again" });


            //        var newUser = new User()
            //        {
            //            Id = usersDomain.Count + 1,
            //            FirstName = user.FirstName,
            //            LastName = user.LastName,
            //            Address = user.Address,
            //            PhoneNumber = user.PhoneNumber,
            //            Email = user.Email,
            //            Password = user.Password,
            //            isAdmin = false,
            //        };
            //        usersDomain.Add(newUser);
            //        return RedirectToAction("Index");
            //    }
            //    else
            //    {
            //        return RedirectToAction("Register", new { error = "Password should start with capital first letter and should contain some digit and $, please try again" });
            //    }
            //}
            //else
            //{
            //    return RedirectToAction("Register", new { error = "Email is not regular, please try again" });

            //}

            var registerUser = _userService.Register(user);
            if (registerUser)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Register", 
                new { error = "Wrong or Existing email or password, please try again" +
                "\n( Password should start with capital first letter and should contain some digit and $ )" });
        }
    }
}
