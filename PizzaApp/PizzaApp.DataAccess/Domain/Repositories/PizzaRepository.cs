using PizzaApp.DataAccess.Domain.Interfaces;
using PizzaApp.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaApp.DataAccess.Domain.Repositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        private IStaticDB _db;
        public PizzaRepository(IStaticDB db)
        {
            _db = db;
        }
        public bool Create(Pizza entity)
        {
            var pizza = _db.GetPizzas().SingleOrDefault(x => x.Id == entity.Id);
            if (pizza == null)
            {
                entity.Id = _db.GetPizzas().Count + 1;
                _db.GetPizzas().Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(Pizza entity)
        {
            var pizza = _db.GetPizzas().SingleOrDefault(x => x.Id == entity.Id);
            if (pizza == null)
            {
                return false;
            }
            _db.GetPizzas().Remove(entity);
            return true;
        }

        public List<Pizza> GetAll()
        {
            return _db.GetPizzas();
        }

        public Pizza GetById(int id)
        {
            return _db.GetPizzas().SingleOrDefault(x => x.Id == id);

        }

        public bool Update(Pizza entity)
        {
            var pizza = _db.GetPizzas().SingleOrDefault(x => x.Id == entity.Id);
            if (pizza == null)
            {
                return false;
            }
            int index = _db.GetPizzas().IndexOf(pizza);
            _db.GetPizzas()[index] = entity;
            return true;
        }
    }
}
