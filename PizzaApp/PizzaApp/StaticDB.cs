using PizzaApp.Models;
using PizzaApp.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp
{
    public static class StaticDB
    {
        public static List<PizzaModel> ListOfPizzas = new List<PizzaModel>()
        {
            new PizzaModel(1, "Capricciosa", PizzaSize.Family, 
                new List<string>(){ "Tomatoes", "Cheese", "Ham", "Mushrooms", "Oregano", "Artichokes"}, 4 * 1.5),
            new PizzaModel(2, "Cheese", PizzaSize.Medium,
                new List<string>(){ "Tomatoes", "Mozzarella cheese", "Parnesan cheese", "Ham", "Mushrooms", "Oregano", "Artichokes"}, 5),
            new PizzaModel(3, "Veggie", PizzaSize.Small,
                new List<string>(){ "Tomatoes", "Carrot", "Broccoli", "Mushrooms", "Cream cheese", "Cucumber"}, 3.5 * 0.75),
            new PizzaModel(4, "Margherita", PizzaSize.Family,
                new List<string>(){ "Tomatoes", "Mozzarella cheese", "Garlic", "Basil", "Pepper"}, 4.5 * 1.5),
            new PizzaModel(5, "Pepperoni", PizzaSize.Family,
                new List<string>(){ "Tomatoes", "Cheese", "Pork", "Beef", "Oregano", "Chili pepper"}, 6 * 1.5),
            new PizzaModel(6, "Chicken", PizzaSize.Medium,
                new List<string>(){ "Tomatoes", "Mozzarella cheese", "Chicken breast", "Parnesan cheese", "Spinach", "Red onion"}, 7),
            new PizzaModel(7, "Hawaiian", PizzaSize.Small,
                new List<string>(){ "Mozzarella cheese", "Ham", "Pineapple", "Cheese"}, 5 * 0.75),
            new PizzaModel(8, "Buffalo", PizzaSize.Family,
                new List<string>(){ "Cheddar cheese", "Chicken breast", "Provolone cheese", " American cheese", "Red onion"}, 5 * 1.5)
        };

        public static List<User> ListOfUsers = new List<User>()
        {
            new User(1, "Bob", "Bobsky", "Bob Street", 080012312345),
            new User(2, "Bobby", "Bobs", "Bobby Street", 080012888896),
            new User(3, "John", "Doe", "John Street", 080012388333),
            new User(4, "Jeny", "Juls", "Jeny Street", 080012374444),
            new User(5, "Mark", "Markus", "Mark Street", 080012175111),
            new User(6, "Dan", "Dansky", "Dan Street", 080012175177),
            new User(7, "Pol", "Polsky", "Pol Street", 080012175777),
            new User(8, "Pirs", "Pirsky", "Pirs Street", 080012175883)
        };

        public static List<Store> ListOfStores = new List<Store>()
        {
            //address, string city, long phone,
            new Store(1, "Dominos", "Street 1", "Skopje", 1234567891, new List<int>(){1, 2, 4, 5, 6, 8 }),
            new Store(2, "Figaro", "Street 2", "Skopje", 1234567891, new List<int>(){ 5, 6, 7, 8 }),
            new Store(3, "The Best Pizzas", "Street 3", "Skopje", 1234567891, new List<int>(){1, 2, 3 }),
            new Store(4, "Pizza Corner", "Street 4", "Skopje", 1234567891, new List<int>(){1, 4, 7, 8}),
            new Store(5, "Pizza INN", "Street 5", "Skopje", 1234567891, new List<int>(){1, 2, 3, 4, 5, 7, 8 })
        };

        public static List<Order> ListOfOrders = new List<Order>()
        {
            new Order(1, 1, 3, 2, true),
            new Order(2, 1, 2, 4, false),
            new Order(3, 3, 1, 1, true),
            new Order(4, 3, 1, 2, true),
            new Order(5, 3, 4, 2, false),
            new Order(6, 5, 3, 1, true),
            new Order(7, 5, 3, 4, true),
            new Order(8, 4, 6, 7, false),
            new Order(9, 4, 8, 8, true),
            new Order(10, 2, 8, 5, true),
            new Order(11, 2, 5, 6, true),
            new Order(12, 3, 5, 3, true)
        };
    }
}
