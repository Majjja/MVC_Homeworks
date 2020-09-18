using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.DataAccess.ViewModels;
using PizzaApp.Services.Interfaces;

namespace PizzaApp.Controllers
{
    public class StoreController : Controller
    {
        private IStoreService _storeService;
        private IPizzaService _pizzaService;
        public StoreController(IStoreService storeService, IPizzaService pizzaService)
        {
            _storeService = storeService;
            _pizzaService = pizzaService;

        }
        public IActionResult Index()
        {
            ViewBag.Title = "All Pizza Stores";
            var allStoresVM = _storeService.GetAllStores();
            return View(allStoresVM);
        }

        public IActionResult Details(int id)
        {
            //var pizzasVM = StaticDB.ListOfPizzas.Select(pizza => new PizzaVM()
            //{
            //    Id = pizza.Id,
            //    Name = pizza.Name,
            //    Size = pizza.Size,
            //    Price = pizza.Price,
            //    Ingredients = pizza.Ingredients,
            //    ImgUrl = pizza.ImgUrl
            //}).ToList();

            //var store = StaticDB.ListOfStores.SingleOrDefault(x => x.Id == id);
            //var storeVM = new StoreVM()
            //{
            //    Id = store.Id,
            //    Name = store.Name,
            //    Address = store.Address,
            //    City = store.City,
            //    PhoneNumber = store.PhoneNumber,
            //    PizzaIds = store.PizzaIds
            //};

            //var pizzasNames = new List<PizzaVM>();
            //foreach (var item in storeVM.PizzaIds)
            //{
            //    foreach (var pizza in pizzasVM)
            //    {
            //        if (item == pizza.Id)
            //        {
            //            pizzasNames.Add(pizza);
            //        }
            //    }
            //}

            var store = _storeService.GetStoreById(id);
            var pizzas = _pizzaService.GetAllPizzas();

            var pizzaMenu = new List<PizzaVM>();

            foreach (var item in store.PizzaIds)
            {
                foreach (var pizza in pizzas)
                {
                    if (item == pizza.Id)
                    {
                        pizzaMenu.Add(pizza);
                    }
                }
            }

            ViewBag.Welcome = "Welcome to  " + store.Name;
            ViewBag.PizzaNames = pizzaMenu;
            return View(pizzaMenu);
        }

        public IActionResult PizzaDetails(int id)
        {
            var pizza = _pizzaService.GetPizzaById(id);
            return RedirectToAction("details/{id}", "pizzas");
        }

        public IActionResult GoToPizzaMenu()
        {
            return RedirectToAction("list", "pizzas", "id");
        }
    }
}
