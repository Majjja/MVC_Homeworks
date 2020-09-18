using PizzaApp.DataAccess.Domain.Interfaces;
using PizzaApp.DataAccess.Domain.Models;
using PizzaApp.DataAccess.ViewModels;
using PizzaApp.Services.Interfaces;
using PizzaApp.Services.MappingToDM;
using PizzaApp.Services.MappingToVM;
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
        public UserVM Login(UserVM user)
        {
            var userDomain = MapperToDM.MapUserVMToUser(user);
            var listOfUsers = _userRepo.GetAll();
            var loggedUser = listOfUsers.SingleOrDefault(u => u.Email == userDomain.Email && u.Password == userDomain.Password);

            if (loggedUser == null)
                return null;

            var returnUser = MapperToVM.MapUserToUserVM(loggedUser);
            return returnUser;
        }

        public bool Register(UserVM userVM)
        {
            var usersDomain = _userRepo.GetAll();

            if (userVM.Email[0] >= 'a' && userVM.Email[0] <= 'z' &&
                userVM.Email[userVM.Email.Length - 1] >= 'a' && userVM.Email[userVM.Email.Length - 1] <= 'z' &&
                userVM.Email.Contains("@") &&
                userVM.Email.Contains("."))
            {
                if (userVM.Password[0] >= 'A' && userVM.Password[0] <= 'Z' &&
                userVM.Password.Contains("$") &&
                userVM.Password.Any(char.IsDigit))
                {
                    var user = MapperToDM.MapUserVMToUser(userVM);
                    var existingEmailOrPass = usersDomain.SingleOrDefault(u => u.Email == user.Email || u.Password == user.Password);

                    if (existingEmailOrPass != null)
                        return false;

                    user.Id = usersDomain.Count + 1;
                    _userRepo.Create(user);
                    return true;
                }
                else return false;
            }
            else return false;
        }

        #region MyRegion
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
        #endregion
    }
}
