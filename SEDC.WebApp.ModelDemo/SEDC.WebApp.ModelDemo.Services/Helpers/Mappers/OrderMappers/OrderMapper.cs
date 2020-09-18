using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.PizzaMappers;
using SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.UserMappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.OrderMappers
{
    public static class OrderMapper
    {
        public static Order OrderVMToOrder(OrderPizzaVM orderVM)
        {
            return new Order()
            {
                //Delivered = orderVM.Delivered,
                //Pizza = new Pizza() { Name = orderVM.Pizza.Name, Size = orderVM.Pizza.Size, Price = orderVM.Pizza.Price, ImageUrl = orderVM.Pizza.ImageUrl},
                //User = new User() { FirstName = orderVM.User.FirstName, LastName = orderVM.User.LastName, Address = orderVM.User.Address, Phone = orderVM.User.Phone}

                Delivered = orderVM.Delivered,
                Pizza = PizzaMapper.PizzaVMToPizza(orderVM.Pizza),
                User = UserMapper.UserVMToUser(orderVM.User)
            };
        }

        public static OrderPizzaVM OrderToOrderVM(Order order)
        {
            return new OrderPizzaVM()
            {
                Delivered = order.Delivered,
                Pizza = PizzaMapper.PizzaToPizzaVM(order.Pizza),
                User = UserMapper.UserToUserVM(order.User)
            };
        }

        public static List<Order> OrdersVMToOrders(List<OrderPizzaVM> models)
        {
            return models.Select(x => new Order()
            {
                Delivered = x.Delivered,
                Pizza = PizzaMapper.PizzaVMToPizza(x.Pizza),
                User = UserMapper.UserVMToUser(x.User)
            }).ToList();
            //return models.Select(order => OrderVMToOrder(order))
        }

        public static List<OrderPizzaVM> OrdersToOrdersVM(List<Order> models)
        {
            return models.Select(x => new OrderPizzaVM()
            {
                Delivered = x.Delivered,
                Pizza = PizzaMapper.PizzaToPizzaVM(x.Pizza),
                User = UserMapper.UserToUserVM(x.User)
            }).ToList();
            //return models.Select(order => OrderToOrderVM(order))
        }
    }
}
