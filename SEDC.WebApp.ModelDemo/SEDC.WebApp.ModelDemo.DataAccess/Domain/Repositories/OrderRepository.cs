using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.WebApp.ModelDemo.DataAccess.Domain.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private IStaticDb _db;
        public OrderRepository(IStaticDb db)
        {
            _db = db;
        }
        public int Create(Order entity)
        {
            var order = _db.GetOrders().SingleOrDefault(x => x.Id == entity.Id);
            if (order == null)
            {
                _db.GetOrders().ToList().Add(entity);
                return 1;
            }
            return -1;
        }

        public int Delete(int id)
        {
            var order = _db.GetOrders().SingleOrDefault(x => x.Id == id);
            if (order == null)
            {
                return -1;
            }
            _db.GetOrders().ToList().Remove(order);
            return 1;
        }

        public List<Order> GetAll()
        {
            return _db.GetOrders().ToList();
        }

        public Order GetById(int id)
        {
            return _db.GetOrders().SingleOrDefault(x => x.Id == id);
        }

        public int Update(Order entity)
        {
            var order = _db.GetOrders().SingleOrDefault(x => x.Id == entity.Id);
            if (order == null)
            {
                return -1;
            }
            int index = _db.GetOrders().ToList().IndexOf(order);
            _db.GetOrders().ToList()[index] = entity;
            return 1;
        }
    }
}
