using PizzaApp.DataAccess.Domain.Interfaces;
using PizzaApp.DataAccess.Domain.Models;
using PizzaApp.DataAccess.ViewModels;
using PizzaApp.Services.Interfaces;
using PizzaApp.Services.MappingToDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaApp.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepo;
        public UserService(IRepository<User> userRepo)
        {
            _userRepo = userRepo;
        }
        public bool Login(UserVM user)
        {
            var userDomain = MapperToDM.MapUserVMToUser(user);

            var listOfUsers = _userRepo.GetAll();

            var loggedUser = listOfUsers.SingleOrDefault(u => u.Email == userDomain.Email && u.Password == userDomain.Password);

            if (loggedUser == null)
                return false;

            return true;
        }

        public bool Register(UserVM user)
        {
            var usersDomain = _userRepo.GetAll();
            var id = user.Id;
            var userDomain = _userRepo.GetById(id);

            if (userDomain.Email[0] >= 'a' && userDomain.Email[0] <= 'z' &&
                userDomain.Email[userDomain.Email.Length - 1] >= 'a' && userDomain.Email[userDomain.Email.Length - 1] <= 'z' &&
                userDomain.Email.Contains("@") &&
                userDomain.Email.Contains("."))
            {
                if (userDomain.Password[0] >= 'A' && userDomain.Password[0] <= 'Z' &&
                userDomain.Password.Contains("$") &&
                userDomain.Password.Any(char.IsDigit))
                {
                    var existingEmailOrPass = usersDomain.SingleOrDefault(u => u.Email == userDomain.Email || u.Password == userDomain.Password);

                    if (existingEmailOrPass != null)
                        //return RedirectToAction("Register", new { error = "Already existing email or password, please try again" });
                        return false;

                    //var newUser = new User()
                    //{
                    //    Id = usersDomain.Count + 1,
                    //    FirstName = user.FirstName,
                    //    LastName = user.LastName,
                    //    Address = user.Address,
                    //    PhoneNumber = user.PhoneNumber,
                    //    Email = user.Email,
                    //    Password = user.Password,
                    //    isAdmin = false,
                    //};
                    var newUser = _userRepo.Create(userDomain);
                    //usersDomain.Add(newUser);
                    //return RedirectToAction("Index");
                    return true;
                }
                else
                {
                    //return RedirectToAction("Register", new { error = "Password should start with capital first letter and should contain some digit and $, please try again" });
                    return false;
                }
            }
            else
            {
                //return RedirectToAction("Register", new { error = "Email is not regular, please try again" });
                return false;
            }
        }
    }
}
