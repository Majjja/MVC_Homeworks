using PizzaApp.DataAccess.Domain.Interfaces;
using PizzaApp.DataAccess.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PizzaApp.DataAccess.Domain.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private IStaticDB _db;
        public OrderRepository(IStaticDB db)
        {
            _db = db;
        }
        public bool Create(Order entity)
        {
            var order = _db.GetOrders().SingleOrDefault(x => x.Id == entity.Id);
            if (order == null)
            {
                entity.Id = _db.GetOrders().Count + 1;
                _db.GetOrders().Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(Order entity)
        {
            var order = _db.GetOrders().SingleOrDefault(x => x.Id == entity.Id);
            if (order == null)
            {
                return false;
            }
            _db.GetOrders().Remove(entity);
            return true;
        }

        public List<Order> GetAll()
        {
            return _db.GetOrders();
        }

        public Order GetById(int id)
        {
            return _db.GetOrders().SingleOrDefault(x => x.Id == id);
        }

        public bool Update(Order entity)
        {
            var order = _db.GetOrders().SingleOrDefault(x => x.Id == entity.Id);
            if (order == null)
            {
                return false;
            }
            int index = _db.GetOrders().IndexOf(order);
            _db.GetOrders()[index] = entity;
            return true;
        }
    }
}
