using PizzaApp.DataAccess.Domain.Enums;
using PizzaApp.DataAccess.Domain.Interfaces;
using PizzaApp.DataAccess.Domain.Models;
using PizzaApp.DataAccess.ViewModels;
using PizzaApp.Services.Interfaces;
using PizzaApp.Services.MappingToDM;
using PizzaApp.Services.MappingToVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PizzaApp.Services.Services
{
    public class PizzaService : IPizzaService
    {
        private IRepository<Pizza> _pizzaRepo;
        public PizzaService(IRepository<Pizza> pizzaRepo)
        {
            _pizzaRepo = pizzaRepo;
        }
        public bool CreateNewPizza(PizzaVM pizzaVM)
        {
            if (pizzaVM.Size == PizzaSize.Medium)
                pizzaVM.Price = pizzaVM.Price;

            if (pizzaVM.Size == PizzaSize.Small)
                pizzaVM.Price *= 0.75;

            if (pizzaVM.Size == PizzaSize.Family)
                pizzaVM.Price *= 1.5;

            var domainPizza = MapperToDM.MapPizzaVMToPizza(pizzaVM);
            var newPizza = _pizzaRepo.GetAll().SingleOrDefault(x => x.Id == domainPizza.Id);
            if (newPizza == null)
            {
                _pizzaRepo.GetAll().Add(newPizza);
                return true;
            }
            return false;
        }

       
        public bool DeletePizza(PizzaVM pizzaVM)
        {
            var domainPizza = MapperToDM.MapPizzaVMToPizza(pizzaVM);
            var newPizza = _pizzaRepo.GetAll().SingleOrDefault(x => x.Id == domainPizza.Id);
            if (newPizza == null)
            {
                return false;
            }
            _pizzaRepo.GetAll().Remove(newPizza);
            return true;
        }

        public List<PizzaVM> GetAllPizzas()
        {
            List<Pizza> pizzas = _pizzaRepo.GetAll();
            var pizzasVM = MapperToVM.MapPizzasToPizzasVM(pizzas);
            return pizzasVM;
        }

        public PizzaVM GetPizzaById(int id)
        {
            Pizza pizza = _pizzaRepo.GetById(id);
            PizzaVM pizzaVM = MapperToVM.MapPizzaToPizzaVM(pizza);
            return pizzaVM;
        }

        public bool UpdatePizza(PizzaVM pizzaVM)
        {
            Pizza pizzaDomain = MapperToDM.MapPizzaVMToPizza(pizzaVM);
            Pizza pizza = _pizzaRepo.GetAll().SingleOrDefault(x => x.Id == pizzaDomain.Id);
            if (pizza == null)
            {
                return false;
            }
            int index = _pizzaRepo.GetAll().IndexOf(pizza);
            _pizzaRepo.GetAll()[index] = pizzaDomain;
            return true;
        }
    }
}
