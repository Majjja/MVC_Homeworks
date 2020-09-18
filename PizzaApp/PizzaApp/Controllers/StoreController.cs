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
            var store = _storeService.GetStoreById(id);
            ViewBag.Welcome = "Welcome to  " + store.Name;
            var storeMenu =_storeService.GetStoreMenu(id);
            return View(storeMenu);
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
