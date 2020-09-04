using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Controllers
{
    [Route("pizzas")]
    public class PizzaController : Controller
    {
        [HttpGet("list")]
        public IActionResult Index()
        {
            List<PizzaModel> pizzas = StaticDB.ListOfPizzas;
            var pizzasVM = pizzas.Select(pizza => new PizzaVM()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Size = pizza.Size,
                Price = pizza.Price,
                Ingredients = pizza.Ingredients
            }).ToList();
            return View(pizzasVM);
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
                Ingredients = model.Ingredients,
                Price = model.Price
            };

            if (newItem.Size == PizzaSize.Medium)
                newItem.Price = model.Price;

            if (newItem.Size == PizzaSize.Small)
                newItem.Price = model.Price * 0.75;
            
            if (newItem.Size == PizzaSize.Family)
                newItem.Price = model.Price * 1.5;


            StaticDB.ListOfPizzas.Add(newItem);
            return RedirectToAction("Index");
        }

        [HttpGet("details/{id}")]
        public IActionResult PizzaDetails(int id)
        {
            var pizza = StaticDB.ListOfPizzas.SingleOrDefault(x => x.Id == id);
            var pizzaVM = new PizzaVM()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Size = pizza.Size,
                Ingredients = pizza.Ingredients,
                Price = pizza.Price
            };
            return View(pizzaVM);
        }

        [HttpGet("delete/{id}")]
        public IActionResult PizzaDelete(int id)
        {
            var pizza = StaticDB.ListOfPizzas.SingleOrDefault(x => x.Id == id);
            return View(pizza);
        }

        [HttpPost("deletedPizza/{id}"), ActionName("DeletedPizzaFromList")]
        public IActionResult DeletedPizzaFromList(int id)
        {
            var pizza = StaticDB.ListOfPizzas.SingleOrDefault(x => x.Id == id);
            StaticDB.ListOfPizzas.Remove(pizza);

            return RedirectToAction("Index");            
        }

        [HttpGet("edit/{id}")]
        public IActionResult PizzaEdit(int id)
        {
            var pizza = StaticDB.ListOfPizzas.SingleOrDefault(x => x.Id == id);
            return View(pizza);
        }

        [HttpPost("edited/{id}"), ActionName("PizzaEdited")]
        public IActionResult PizzaEdited(PizzaModel model)
        {

            var newPizza = new PizzaModel()
            {
                Id = model.Id,
                Name = model.Name,
                Size = model.Size,
                Ingredients = model.Ingredients,
                Price = model.Price
            };
            StaticDB.ListOfPizzas.Add(newPizza);
            return RedirectToAction("Index");

        }

        public IActionResult BackToStores()
        {
            return RedirectToAction("Index", "Store");
        }
    }
}
