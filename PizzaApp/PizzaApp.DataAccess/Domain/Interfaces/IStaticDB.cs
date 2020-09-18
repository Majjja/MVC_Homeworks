using PizzaApp.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.DataAccess.Domain.Interfaces
{
    public interface IStaticDB
    {
        List<Pizza> GetPizzas();
        List<User> GetUsers();
        List<Store> GetStores();
        List<Order> GetOrders();
    }
}
