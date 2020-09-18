using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SEDC.WebApp.ModelDemo.DataAccess.Domain.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private IStaticDb _db;
        public UserRepository(IStaticDb db)
        {
            _db = db;
        }
        public int Create(User entity)
        {
            var user = _db.GetUsers().SingleOrDefault(x => x.Id == entity.Id);
            if (user == null)
            {
                _db.GetUsers().ToList().Add(entity);
                return 1;
            }
            return -1;
        }

        public int Delete(int id)
        {
            var user = _db.GetUsers().SingleOrDefault(x => x.Id == id);
            if (user == null)
            {
                return -1;
            }
            _db.GetUsers().ToList().Remove(user);
            return 1;

        }

        public List<User> GetAll()
        {
            return _db.GetUsers().ToList();
        }

        public User GetById(int id)
        {
            return _db.GetUsers().SingleOrDefault(x => x.Id == id);

        }

        public int Update(User entity)
        {
            var user = _db.GetUsers().SingleOrDefault(x => x.Id == entity.Id);
            if (user == null)
            {
                return -1;
            }
            int index = _db.GetUsers().ToList().IndexOf(user);
            _db.GetUsers().ToList()[index] = entity;
            return 1;
        }
    }
}
