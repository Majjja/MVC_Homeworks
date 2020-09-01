using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models;

namespace PizzaApp.Controllers
{
    [Route("pizzas")]
    public class PizzaController : Controller
    {
        [HttpGet("list")]
        public IActionResult Index()
        {
            List<PizzaModel> pizzas = StaticDB.ListOfPizzas;
            return View(pizzas);
        }

        [HttpGet("create")]
        public IActionResult CreatePizza()
        {
            return View();
        }

        [HttpPost("createNew")]
        public IActionResult CreateNewPizza(PizzaModel model)
        {
            var newItem = new PizzaModel()
            {
                Id = StaticDB.ListOfPizzas.Count + 1,
                Name = model.Name,
                Size = model.Size,
                Price = model.Price
            };

            StaticDB.ListOfPizzas.Add(newItem);
            return RedirectToAction("Index");
        }

        [HttpGet("details/{id}")]
        public IActionResult PizzaDetails(int id)
        {
            var pizza = StaticDB.ListOfPizzas.SingleOrDefault(x => x.Id == id);
            return View(pizza);
        }

        [HttpGet("delete/{id}")]
        public IActionResult PizzaDelete(int id)
        {
            var pizza = StaticDB.ListOfPizzas.SingleOrDefault(x => x.Id == id);
            return View(pizza);
        }

        [HttpDelete("deletePizza/{id}")]
        public IActionResult DeletePizzaFromList(int id)
        {
            var pizza = StaticDB.ListOfPizzas.SingleOrDefault(x => x.Id == id);
            StaticDB.ListOfPizzas.Remove(pizza);
            return RedirectToAction("Index");            
        }
    }
}
