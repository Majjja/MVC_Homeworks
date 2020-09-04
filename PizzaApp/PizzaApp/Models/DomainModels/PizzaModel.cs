using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.Models
{
    public class PizzaModel
    {
        public PizzaModel()
        {
            //Ingredients = new List<string>();
        }

        public PizzaModel(int id, string name, PizzaSize size, List<string> ingredients, double price)
        {
            Id = id;
            Name = name;
            Size = size;
            Ingredients = ingredients;
            Price = price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        public List<string> Ingredients { get; set; }
        public double Price { get; set; }
    }

    public enum PizzaSize
    {
        Small = 1,
        Medium = 2, 
        Family = 3
    }
}
