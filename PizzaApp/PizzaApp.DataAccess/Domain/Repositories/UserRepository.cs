using PizzaApp.DataAccess.Domain.Interfaces;
using PizzaApp.DataAccess.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.DataAccess.Domain.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private IStaticDB _db;
        public UserRepository(IStaticDB db)
        {
            _db = db;
        }
        public bool Create(User entity)
        {
            var user = _db.GetUsers().SingleOrDefault(x => x.Id == entity.Id);
            if (user == null)
            {
                _db.GetUsers().Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(User entity)
        {
            var user = _db.GetUsers().SingleOrDefault(x => x.Id == entity.Id);
            if (user == null)
            {
                return false;
            }
            _db.GetUsers().Remove(entity);
            return true;
        }

        public List<User> GetAll()
        {
            return _db.GetUsers();
        }

        public User GetById(int id)
        {
            return _db.GetUsers().SingleOrDefault(x => x.Id == id);
        }

        public bool Update(User entity)
        {
            var user = _db.GetUsers().SingleOrDefault(x => x.Id == entity.Id);
            if (user == null)
            {
                return false;
            }
            int index = _db.GetUsers().IndexOf(user);
            _db.GetUsers()[index] = entity;
            return true;
        }
    }
}
