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

        }

        public PizzaModel(int id, string name, PizzaSize size, double price)
        {
            Id = id;
            Name = name;
            Size = size;
            Price = CreatePrice(price);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        public double Price { get; set; }

        private double CreatePrice(double price)
        {
            if (Size == PizzaSize.Small)
                return Price = price * 0.75;
            if (Size == PizzaSize.Medium)
                return Price = price;
            if (Size == PizzaSize.Family)
                return Price = price * 1.5;
            else return 0;
        }
    }

    public enum PizzaSize
    {
        Small = 1,
        Medium, 
        Family
    }

    //public enum PizzaName
    //{
    //    Capricciosa = 1,
    //    Cheese,
    //    Veggie,
    //    Margherita
    //}
}
