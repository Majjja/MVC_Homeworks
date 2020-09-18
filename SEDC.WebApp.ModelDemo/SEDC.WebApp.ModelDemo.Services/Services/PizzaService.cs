using SEDC.WebApp.ModelDemo.DataAccess.Domain.Enums;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.PizzaMappers;
using SEDC.WebApp.ModelDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Services
{
    public class PizzaService : IPizzaService
    {
        private IRepository<Pizza> _pizzaRepo;
        public PizzaService(IRepository<Pizza> pizzaRepo)
        {
            _pizzaRepo = pizzaRepo;
        }
        public List<PizzaVM> GetAllPizzas()
        {
            var allPizzas = _pizzaRepo.GetAll();
            return PizzaMapper.PizzasToPizzasVM(allPizzas);
        }

        public PizzaVM GetPizzaById(int id)
        {
            var pizza = _pizzaRepo.GetById(id);
            if (pizza == null)
            {
                return null;
            }
            return PizzaMapper.PizzaToPizzaVM(pizza);

            //try
            //{
            //    var pizza = _pizzaRepo.GetById(id);
            //    return PizzaMapper.PizzaToPizzaVM(pizza);
            //}
            //catch (Exception)
            //{
            //    return null;
            //}
        }

        public List<PizzaVM> GetPizzasBySize(PizzaSize size)
        {
            var pizzas = _pizzaRepo.GetAll().Where(x => x.Size == size).ToList();
            return PizzaMapper.PizzasToPizzasVM(pizzas);
        }
    }
}
