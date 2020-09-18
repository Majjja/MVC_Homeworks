using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.Services.Interfaces;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class HomeController : Controller
    {
        private IPizzaService _pizzaService;
        public HomeController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        public IActionResult Index()
        {
            ViewData["Heading"] = "Pizzas menu";
            ViewBag.Title = "Welcome to our pizza app!";
            var allPizzasVM = _pizzaService.GetAllPizzas();
            return View(allPizzasVM);
        }

        public IActionResult PizzaDetails(int id)
        {
            var pizzaModel = _pizzaService.GetPizzaById(id);
            return View(pizzaModel);
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

    }
}
