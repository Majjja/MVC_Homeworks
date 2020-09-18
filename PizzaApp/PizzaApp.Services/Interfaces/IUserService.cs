using PizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Services.Interfaces
{
    public interface IUserService
    {
        bool Login(UserVM user);

        bool Register(UserVM user);
    }
}
