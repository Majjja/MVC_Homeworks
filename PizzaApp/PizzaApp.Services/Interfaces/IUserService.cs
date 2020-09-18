using PizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Services.Interfaces
{
    public interface IUserService
    {
        UserVM Login(UserVM user);

        bool Register(UserVM userVM);
    }
}
