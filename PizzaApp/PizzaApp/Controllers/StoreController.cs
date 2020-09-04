using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "All Pizza Stores";
            
            var allStoresVM = StaticDB.ListOfStores.Select(store => new StoreVM()
            {
                Id = store.Id,
                Name = store.Name,
                PizzaIds = store.PizzaIds
            }).ToList();

            return View(allStoresVM);
        }

        public IActionResult Details(int id)
        {
            ViewBag.Welcome = "Welcome to our Pizza Store!!!";

            var pizzas = StaticDB.ListOfPizzas.Select(pizza => new PizzaVM()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Size = pizza.Size,
                Price = pizza.Price,
                Ingredients = pizza.Ingredients
            }).ToList();

            var store = StaticDB.ListOfStores.SingleOrDefault(x => x.Id == id);
            var storeVM = new StoreVM()
            {
                Id = store.Id,
                Name = store.Name,
                Address = store.Address,
                City = store.City,
                PhoneNumber = store.PhoneNumber,
                PizzaIds = store.PizzaIds
            };

            var pizzasNames = new List<PizzaVM>();
            foreach (var item in storeVM.PizzaIds)
            {
                foreach (var pizza in pizzas)
                {
                    if (item == pizza.Id)
                    {
                        pizzasNames.Add(pizza);
                    }
                }
            }
            ViewBag.PizzaNames = pizzasNames;
            return View(storeVM);
        }

        public IActionResult PizzaDetails(int id)
        {
            var pizza = StaticDB.ListOfPizzas.Where(x => x.Id == id);
            return RedirectToAction("details/{id}", "pizzas");
        }

        public IActionResult GoToPizzaMenu()
        {
            return RedirectToAction("list", "pizzas");
        }
    }
}
