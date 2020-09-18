using PizzaApp.DataAccess.Domain.Models;
using PizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaApp.Services.MappingToVM
{
    public static class MapperToVM
    {
        public static PizzaVM MapPizzaToPizzaVM(Pizza pizza)
        {
            return new PizzaVM()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Size = pizza.Size,
                Price = pizza.Price,
                Ingredients = pizza.Ingredients,
                ImgUrl = pizza.ImgUrl
            };
        }

        public static StoreVM MapStoreToStoreVM(Store store)
        {
            return new StoreVM()
            {
                Id = store.Id,
                Name = store.Name,
                Address = store.Address,
                City = store.City,
                PhoneNumber = store.PhoneNumber,
                ListOfPizzas = MapPizzasToPizzasVM(store.ListOfPizzas)
            };
        }

        public static UserVM MapUserToUserVM(User user)
        {
            return new UserVM()
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

        public static OrderVM MapOrderToOrderVM(Order order)
        {
            return new OrderVM()
            {
                Id = order.Id,
                UserId = order.UserId,
                PizzaId = order.PizzaId,
                StoreId = order.StoreId,
                IsDelivered = order.IsDelivered
            };
        }

        public static List<PizzaVM> MapPizzasToPizzasVM(List<Pizza> pizzas)
        {
            return pizzas.Select(x => new PizzaVM()
            {
                Id = x.Id,
                Name = x.Name,
                Size = x.Size,
                Price = x.Price,
                Ingredients = x.Ingredients,
                ImgUrl = x.ImgUrl
            }).ToList();

            //return pizzas.Select(x => MapPizzaToPizzaVM(x)).ToList();
        }

        public static List<StoreVM> MapStoresToStoresVM(List<Store> stores)
        {
            return stores.Select(x => new StoreVM()
            {
                Id = x.Id,
                Name = x.Name,
                PhoneNumber = x.PhoneNumber,
                Address = x.Address,
                City = x.City,
                ListOfPizzas = MapPizzasToPizzasVM(x.ListOfPizzas)
            }).ToList();

            //return stores.Select(x => MapStoreToStoreVM(x)).ToList();
        }

        public static List<UserVM> MapUsersToUsersVM(List<User> users)
        {
            return users.Select(x => new UserVM()
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

            //return users.Select(x => MapUserToUserVM(x)).ToList();
        }

        public static List<OrderVM> MapOrdersToOrdersVM(List<Order> orders)
        {
            return orders.Select(x => new OrderVM()
            {
                Id = x.Id,
                PizzaId = x.PizzaId,
                StoreId = x.StoreId,
                UserId = x.UserId,
                IsDelivered = x.IsDelivered
            }).ToList();

            //return orders.Select(x => MapOrderToOrderVM(x)).ToList();
        }
    }
}
