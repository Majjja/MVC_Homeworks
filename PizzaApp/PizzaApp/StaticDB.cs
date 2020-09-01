using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp
{
    public static class StaticDB
    {
        public static List<PizzaModel> ListOfPizzas = new List<PizzaModel>()
        {
            new PizzaModel(1, "Capricciosa", PizzaSize.Family, 200 * 1.5),
            new PizzaModel(2, "Cheese", PizzaSize.Medium, 305),
            new PizzaModel(3, "Veggie", PizzaSize.Small, 180 * 0.75),
            new PizzaModel(4, "Margherita", PizzaSize.Family, 250 * 1.5),
        };
    }
}
