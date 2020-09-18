using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using SEDC.WebApp.ModelDemo.Services.Interfaces;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IPizzaService _pizzaService;
        private IUserService _userService;

        public OrderController(IOrderService orderService, IPizzaService pizzaService, IUserService userService)
        {
            _orderService = orderService;
            _pizzaService = pizzaService;
            _userService = userService;
        }
        public IActionResult Index(int id, string error)
        {
            //var pizzaDomain = StaticDb.Menu.SingleOrDefault(pizza => pizza.Id == id);
            //var pizzaVM = new PizzaVM()
            //{
            //    Id = pizzaDomain.Id,
            //    Name = pizzaDomain.Name,
            //    Size = pizzaDomain.Size,
            //    Price = pizzaDomain.Price,
            //    ImageUrl = pizzaDomain.ImageUrl
            //};
            //var userVM = new UserVM();
            //var orderVM = new OrderPizzaVM() { Pizza = pizzaVM, User = userVM };

            var pizzaVM = _pizzaService.GetPizzaById(id);
            var userVM = new UserVM();
            var orderVM = new OrderPizzaVM() { Pizza = pizzaVM, User = userVM };

            ViewBag.Error = error == null ? "" : error;
            return View(orderVM);
        }

        [HttpPost]
        public IActionResult Index(OrderPizzaVM orderModel)
        {
            if (string.IsNullOrEmpty(orderModel.User.Address))
            {
                return RedirectToAction("Index", "Order", new { id = orderModel.Pizza.Id, error = "All fields requied" });
            }

            //Pizza pizza = StaticDb.Menu.SingleOrDefault(p => p.Id == orderModel.Pizza.Id);
            //User user = new User()
            //{
            //    Id = StaticDb.Users.Count + 1,
            //    Address = orderModel.User.Address,
            //    FirstName = orderModel.User.FirstName,
            //    LastName = orderModel.User.LastName,
            //    Phone = orderModel.User.Phone
            //};
            //Order order = new Order()
            //{
            //    Delivered = false,
            //    Id = StaticDb.Orders.Count + 1,
            //    Pizza = pizza,
            //    User = user
            //};
            //StaticDb.Users.Add(user);
            //StaticDb.Orders.Add(order);

            var pizza = _pizzaService.GetPizzaById(orderModel.Pizza.Id);
            var newUser = new UserVM()
            {
                FirstName = orderModel.User.FirstName,
                LastName = orderModel.User.LastName,
                Address = orderModel.User.Address,
                Phone = orderModel.User.Phone
            };
            orderModel.Pizza = pizza;
            orderModel.User = newUser;
            _userService.CreateNewUser(newUser);
            _orderService.CreateNewOrder(orderModel);
            return RedirectToAction("OrderMenu");
        }

        public IActionResult OrderMenu()
        {
            var orders = _orderService.GetAllOrders();
            return View(orders);
        }
    }
}
