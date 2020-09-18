using PizzaApp.DataAccess.Domain.Models;
using PizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaVM> GetAllPizzas();
        PizzaVM GetPizzaById(int id);
        bool CreateNewPizza(PizzaVM pizza);
        bool UpdatePizza(PizzaVM pizza);
        bool DeletePizza(PizzaVM pizza);
    }
}
