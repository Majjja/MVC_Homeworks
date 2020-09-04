using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.Models.DomainModels
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long PhoneNumber { get; set; }
        public List<int> PizzaIds { get; set; }

        public Store()
        {

        }
        public Store(int id, string name, string address, string city, long phone, List<int> pizzaids)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
            PhoneNumber = phone;
            PizzaIds = pizzaids;
        }
    }
}
