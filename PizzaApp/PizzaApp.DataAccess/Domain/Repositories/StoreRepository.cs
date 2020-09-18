using PizzaApp.DataAccess.Domain.Interfaces;
using PizzaApp.DataAccess.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.DataAccess.Domain.Repositories
{
    public class StoreRepository : IRepository<Store>
    {
        private IStaticDB _db;
        public StoreRepository(IStaticDB db)
        {
            _db = db;
        }
        public bool Create(Store entity)
        {
            var store = _db.GetStores().SingleOrDefault(x => x.Id == entity.Id);
            if (store == null)
            {
                entity.Id = _db.GetStores().Count + 1;
                _db.GetStores().Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(Store entity)
        {
            var store = _db.GetStores().SingleOrDefault(x => x.Id == entity.Id);
            if (store == null)
            {
                return false;
            }
            _db.GetStores().Remove(entity);
            return true;
        }

        public List<Store> GetAll()
        {
            return _db.GetStores();
        }

        public Store GetById(int id)
        {
            return _db.GetStores().SingleOrDefault(x => x.Id == id);
        }

        public bool Update(Store entity)
        {
            var store = _db.GetStores().SingleOrDefault(x => x.Id == entity.Id);
            if (store == null)
            {
                return false;
            }
            int index = _db.GetStores().IndexOf(store);
            _db.GetStores()[index] = entity;
            return true;
        }
    }
}
