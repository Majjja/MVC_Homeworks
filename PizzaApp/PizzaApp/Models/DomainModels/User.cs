using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.Models.DomainModels
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }

        public User()
        {

        }
        public User(int id, string firstname, string lastname, string address, long phone)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            PhoneNumber = phone;
        }

    }
}
