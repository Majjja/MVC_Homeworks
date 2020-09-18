using PizzaApp.DataAccess;
using PizzaApp.DataAccess.Domain.Models;
using PizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaApp.Services.MappingToDM
{
    public static class MapperToDM
    {
        public static Pizza MapPizzaVMToPizza(PizzaVM pizza)
        {
            return new Pizza()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Size = pizza.Size,
                Price = pizza.Price,
                Ingredients = pizza.Ingredients,
                ImgUrl = pizza.ImgUrl
            };
        }

        public static Store MapStoreVMToStore(StoreVM store)
        {
            return new Store()
            {
                Id = store.Id,
                Name = store.Name,
                Address = store.Address,
                City = store.City,
                PhoneNumber = store.PhoneNumber,
                ListOfPizzas = MapPizzasVMToPizzas(store.ListOfPizzas)
            };
        }

        public static User MapUserVMToUser(UserVM user)
        {
            return new User()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Password = user.Password,
                IsAdmin = user.IsAdmin
            };
        }

        public static Order MapOrderVMToOrder(OrderVM order)
        {
            return new Order()
            {
                Id = order.Id,
                UserId = order.UserId,
                PizzaId = order.PizzaId,
                StoreId = order.StoreId,
                IsDelivered = order.IsDelivered
            };
        }

        public static List<Pizza> MapPizzasVMToPizzas(List<PizzaVM> pizzas)
        {
            return pizzas.Select(x => new Pizza()
            {
                Id = x.Id,
                Name = x.Name,
                Size = x.Size,
                Price = x.Price,
                Ingredients = x.Ingredients,
                ImgUrl = x.ImgUrl

            }).ToList();

            //return pizzas.Select(x => MapPizzaVMToPizza(x)).ToList();
        }

        public static List<Store> MapStoresVMToStores(List<StoreVM> stores)
        {
            return stores.Select(x => new Store()
            {
                Id = x.Id,
                Name = x.Name,
                PhoneNumber = x.PhoneNumber,
                Address = x.Address,
                City = x.City,
                ListOfPizzas = MapPizzasVMToPizzas(x.ListOfPizzas)
            }).ToList();

            //return stores.Select(x => MapStoreVMToStore(x)).ToList();
        }

        public static List<User> MapUsersVMToUsers(List<UserVM> users)
        {
            return users.Select(x => new User()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                PhoneNumber = x.PhoneNumber,
                Password = x.Password,
                Email = x.Email,
                IsAdmin = x.IsAdmin
            }).ToList();

            //return users.Select(x => MapUserVMToUser(x)).ToList();
        }

        public static List<Order> MapOrdersVMToOrders(List<OrderVM> orders)
        {
            return orders.Select(x => new Order()
            {
                Id = x.Id,
                PizzaId = x.PizzaId,
                StoreId = x.StoreId,
                UserId = x.UserId,
                IsDelivered = x.IsDelivered
            }).ToList();

            //return orders.Select(x => MapOrderVMToOrder(x)).ToList();
        }
    }
}
