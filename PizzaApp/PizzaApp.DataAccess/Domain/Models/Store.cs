using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.DataAccess.Domain.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long PhoneNumber { get; set; }
        public List<int> PizzaIds { get; set; }

    }
}
