using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.DataAccess.ViewModels;
using PizzaApp.Services.Interfaces;

namespace PizzaApp.Controllers
{
    [Route("pizzas")]
    public class PizzaController : Controller
    {
        private IPizzaService _pizzaService;
        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        [HttpGet("list")]
        public IActionResult Index()
        {
            var pizzasVM = _pizzaService.GetAllPizzas();
            return View(pizzasVM);
        }

        [HttpGet("create")]
        public IActionResult CreatePizza()
        {
            return View();
        }

        [HttpPost("createNew")]
        public IActionResult CreateNewPizza(PizzaVM model)
        {
            _pizzaService.CreateNewPizza(model);
            return RedirectToAction("Index");
        }

        [HttpGet("details/{id}")]
        public IActionResult PizzaDetails(int id)
        {
            var pizzaVM = _pizzaService.GetPizzaById(id);
            return View(pizzaVM);
        }

        [HttpGet("delete/{id}")]
        public IActionResult PizzaDelete(int id)
        {
            var pizzaVM = _pizzaService.GetPizzaById(id);
            return View(pizzaVM);
        }

        [HttpPost("deletedPizza/{id}"), ActionName("DeletedPizzaFromList")]
        public IActionResult DeletedPizzaFromList(int id)
        {
            var pizzaVM = _pizzaService.GetPizzaById(id);
            _pizzaService.DeletePizza(pizzaVM);
            return RedirectToAction("Index");            
        }

        [HttpGet("edit/{id}")]
        public IActionResult PizzaEdit(int id)
        {
            var pizzaVM = _pizzaService.GetPizzaById(id);
            return View(pizzaVM);
        }

        [HttpPost("edited/{id}"), ActionName("PizzaEdited")]
        public IActionResult PizzaEdited(PizzaVM model)
        {
            _pizzaService.UpdatePizza(model);
            return RedirectToAction("Index");
        }

        public IActionResult BackToStores()
        {
            return RedirectToAction("Index", "Store");
        }
    }
}