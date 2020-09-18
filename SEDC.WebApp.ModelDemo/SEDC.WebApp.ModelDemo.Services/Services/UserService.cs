using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.UserMappers;
using SEDC.WebApp.ModelDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepo;
        public UserService(IRepository<User> userRepo)
        {
            _userRepo = userRepo;
        }
        public string CreateNewUser(UserVM model)
        {
            var user = UserMapper.UserVMToUser(model);
            var responce = _userRepo.Create(user);
            if (responce == -1)
            {
                return "Was not successfull, please try again later.";
            }
            return "User successfully created!";
        }

        public List<UserVM> GetAllUsers()
        {
            var users = _userRepo.GetAll();
            return UserMapper.UsersToUsersVM(users);
        }

        public List<UserVM> GetUserByName(string name)
        {
            var users = _userRepo.GetAll().Where(x => x.FirstName.ToLower() == name.ToLower()).ToList();
            return UserMapper.UsersToUsersVM(users);
        }
    }
}
