using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SEDC.WebApp.ModelDemo.DataAccess.Domain.Repositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        private IStaticDb _db;
        public PizzaRepository(IStaticDb db)
        {
            _db = db;
        }
        public int Create(Pizza entity)
        {
            var pizza = _db.GetPizzas().SingleOrDefault(x => x.Id == entity.Id);
            if (pizza == null)
            {
                _db.GetPizzas().ToList().Add(entity);
                return 1;
            }
            return -1;
        }

        public int Delete(int id)
        {
            var pizza = _db.GetPizzas().SingleOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                return -1;
            }
            _db.GetPizzas().ToList().Remove(pizza);
            return 1;
        }

        public List<Pizza> GetAll()
        {
            return _db.GetPizzas().ToList();
        }

        public Pizza GetById(int id)
        {
            return _db.GetPizzas().SingleOrDefault(x => x.Id == id);

        }

        public int Update(Pizza entity)
        {
            var pizza = _db.GetPizzas().SingleOrDefault(x => x.Id == entity.Id);
            if (pizza == null)
            {
                return -1;
            }
            int index = _db.GetPizzas().ToList().IndexOf(pizza);
            _db.GetPizzas().ToList()[index] = entity;
            return 1; 
        }
    }
}
