using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.UserMappers
{
    public static class UserMapper
    {
        public static User UserVMToUser(UserVM model)
        {
            return new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                Phone = model.Phone
            };
        }

        public static UserVM UserToUserVM(User model)
        {
            return new UserVM()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                Phone = model.Phone
            };
        }

        public static List<User> UsersVMToUsers(List<UserVM> models)
        {
            return models.Select(x => new User()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                Phone = x.Phone
            }).ToList();
            
            //return models.Select(x => UserVMToUser(x))
        }

        public static List<UserVM> UsersToUsersVM(List<User> models)
        {
            return models.Select(x => new UserVM()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                Phone = x.Phone
            }).ToList();
            //return models.Select(x => UserToUserVM(x))
        }
    }
}
