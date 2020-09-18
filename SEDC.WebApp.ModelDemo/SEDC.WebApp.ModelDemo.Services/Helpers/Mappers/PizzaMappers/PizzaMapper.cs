using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.PizzaMappers
{
    public static class PizzaMapper
    {
        public static Pizza PizzaVMToPizza(PizzaVM model)
        {
            return new Pizza()
            {
                Id = model.Id,
                Name = model.Name,
                Size = model.Size,
                Price = model.Price,
                ImageUrl = model.ImageUrl
            };
        }

        public static PizzaVM PizzaToPizzaVM(Pizza model)
        {
            return new PizzaVM()
            {
                Id = model.Id,
                Name = model.Name,
                Size = model.Size,
                Price = model.Price,
                ImageUrl = model.ImageUrl
            };
        }

        public static List<Pizza> PizzasVMToPizzas(List<PizzaVM> models)
        {
            return models.Select(x => new Pizza()
            {
                Id = x.Id,
                Name = x.Name,
                Size = x.Size,
                Price = x.Price,
                ImageUrl = x.ImageUrl
            }).ToList();
            //return models.Select(x => PizzaVMToPizza(x))
        }

        public static List<PizzaVM> PizzasToPizzasVM(List<Pizza> models)
        {
            return models.Select(x => new PizzaVM()
            {
                Id = x.Id,
                Name = x.Name,
                Size = x.Size,
                Price = x.Price,
                ImageUrl = x.ImageUrl
            }).ToList();
            //return models.Select(x => PizzaToPizzaVM(x))
        }
    }
}
