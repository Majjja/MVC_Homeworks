using PizzaApp.DataAccess.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.DataAccess.Domain.Models
{
    public class Pizza
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        public List<string> Ingredients { get; set; }
        public double Price { get; set; }
        public string ImgUrl { get; set; }
    }

   
}
