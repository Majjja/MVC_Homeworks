using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.Services.Interfaces;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class TestController : Controller
    {
        private IPizzaService _pizzaService;
        public TestController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        public IActionResult Index()
        {
            var pizzasVM = _pizzaService.GetAllPizzas();
            var pizzaVM = _pizzaService.GetPizzaById(0);
            ViewBag.Pizzas = pizzasVM;
            return View(pizzaVM);
        }

        public IActionResult Testing()
        {
            var pizza = _pizzaService.GetPizzaById(0);
            return View(pizza);
        }
    }
}
