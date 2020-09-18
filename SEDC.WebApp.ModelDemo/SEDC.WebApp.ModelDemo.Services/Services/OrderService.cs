using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.OrderMappers;
using SEDC.WebApp.ModelDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Services
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepo;
        public OrderService(IRepository<Order> orderRepo)
        {
            _orderRepo = orderRepo;
        }
        public string CreateNewOrder(OrderPizzaVM model)
        {
            var order = OrderMapper.OrderVMToOrder(model);
            order.Id = _orderRepo.GetAll().Count + 1;
            int responce = _orderRepo.Create(order);
            if (responce == -1)
            {
                return "Was not successfull, please try again later.";
            }
            return "Order successfully created!";
        }

        public string DeleteExistingOrder(int id)
        {
            int responce = _orderRepo.Delete(id);
            if (responce == -1)
            {
                return "Was not successfull, please try again later.";
            }
            return "Order successfully deleted!";
        }

        public List<OrderPizzaVM> GetAllOrders()
        {
            var orders = _orderRepo.GetAll();
            var mappedOrders = OrderMapper.OrdersToOrdersVM(orders);
            return mappedOrders;
        }

        public OrderPizzaVM GetOrderById(int id)
        {
            var order = _orderRepo.GetById(id);
            return OrderMapper.OrderToOrderVM(order);
        }
    }
}
