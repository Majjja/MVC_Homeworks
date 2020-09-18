
using PizzaApp.DataAccess.Domain.Enums;
using PizzaApp.DataAccess.Domain.Interfaces;
using PizzaApp.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.DataAccess
{
    public class StaticDB : IStaticDB
    {
        List<Order> IStaticDB.GetOrders()
        {
            return new List<Order>()
            {
                new Order()
                {
                     Id = 1,
                    StoreId = 1,
                    UserId = 3,
                    PizzaId = 2,
                    IsDelivered = true
                },
                new Order()
                {
                     Id = 2,
                    StoreId = 1,
                    UserId = 2,
                    PizzaId = 4,
                    IsDelivered = false
                },
                new Order()
                {
                     Id = 3,
                    StoreId = 3,
                    UserId = 1,
                    PizzaId = 1,
                    IsDelivered = true
                },
                 new Order()
                {
                     Id = 4,
                    StoreId =  3,
                    UserId = 1,
                    PizzaId = 2,
                    IsDelivered = true
                 },
                new Order()
                {
                     Id = 5,
                    StoreId = 3,
                    UserId = 4,
                    PizzaId = 2,
                    IsDelivered = false
                },
                new Order()
                {
                     Id = 6,
                    StoreId = 5,
                    UserId = 3,
                    PizzaId = 1,
                    IsDelivered = true
                },
                new Order()
                {
                    Id = 7,
                    StoreId = 5,
                    UserId =  3,
                    PizzaId =  4,
                    IsDelivered = true
                },
                new Order()
                {
                    Id = 8,
                    StoreId = 4,
                    UserId =  6,
                    PizzaId = 7,
                    IsDelivered = false
                },
                new Order()
                {
                    Id = 9,
                    StoreId = 4,
                    UserId = 8,
                    PizzaId = 8,
                    IsDelivered = true
                },
                new Order()
                {
                    Id = 10,
                    StoreId = 2,
                    UserId = 8,
                    PizzaId = 5,
                    IsDelivered = true
                },
                new Order()
                {
                    Id = 11,
                    StoreId = 2,
                    UserId = 5,
                    PizzaId = 6,
                    IsDelivered = true
                },
                new Order()
                {
                    Id = 12,
                    StoreId = 3,
                    UserId = 5,
                    PizzaId = 3,
                    IsDelivered = true
                }
            };
        }

        List<Pizza> IStaticDB.GetPizzas()
        {
            return new List<Pizza>()
            {
                new Pizza()
                {
                    Id = 1,
                    Name = "Capricciosa",
                    Size = PizzaSize.Medium,
                    Ingredients = new List<string>(){ "Tomatoes", "Cheese", "Ham", "Mushrooms", "Oregano", "Artichokes"},
                    Price = 4,
                    ImgUrl = "https://speisekarte.menu/storage/media/dishes_main/1763345/conversions/dish_thumbnail.jpg"
                },
                new Pizza()
                {
                    Id = 2,
                    Name = "Cheese",
                    Size = PizzaSize.Medium,
                    Ingredients = new List<string>(){ "Tomatoes", "Mozzarella cheese", "Parnesan cheese", "Ham", "Mushrooms", "Oregano", "Artichokes"},
                    Price = 5,
                    ImgUrl = "https://static.toiimg.com/thumb/53110049.cms?width=1200&height=900"
                },
                new Pizza()
                {
                    Id = 3,
                    Name = "Veggie",
                    Size = PizzaSize.Medium,
                    Ingredients = new List<string>(){ "Tomatoes", "Carrot", "Broccoli", "Mushrooms", "Cream cheese", "Cucumber"},
                    Price = 3.5,
                    ImgUrl = "https://www.tasteofhome.com/wp-content/uploads/2018/01/Grilled-Veggie-Pizza_EXPS_LSBZ18_48960_D01_18_6b.jpg"
                },
                 new Pizza()
                {
                    Id = 4,
                    Name = "Margherita",
                    Size = PizzaSize.Medium,
                    Ingredients = new List<string>(){  "Tomatoes", "Mozzarella cheese", "Garlic", "Basil", "Pepper"},
                    Price = 4.5,
                    ImgUrl = "https://i2.wp.com/www.5dollardinners.com/wp-content/uploads/2016/01/Chicken-Margherita-Pizza-from-5DollarDinners-500x375.jpg"
                },
                new Pizza()
                {
                    Id = 5,
                    Name = "Pepperoni",
                    Size = PizzaSize.Medium,
                    Ingredients = new List<string>(){ "Tomatoes", "Cheese", "Pork", "Beef", "Oregano", "Chili pepper"},
                    Price =  6,
                    ImgUrl = "https://www.moulinex-me.com/medias/?context=bWFzdGVyfHJvb3R8MTQzNTExfGltYWdlL2pwZWd8aDM2L2g1Mi8xMzA5NzI3MzI2MjExMC5qcGd8N2MxZDhmNmI5ZTgzZDZlZWQyZGQ4YjFlZjUyNDlkMTExYjdkZDdlZmFkY2I0N2NmNjljOGViNmExZjIyMDU4Yw"
                },
                new Pizza()
                {
                    Id = 6,
                    Name = "Chicken",
                    Size = PizzaSize.Medium,
                    Ingredients = new List<string>(){ "Tomatoes", "Mozzarella cheese", "Chicken breast", "Parnesan cheese", "Spinach", "Red onion"},
                    Price = 7,
                    ImgUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/bbq-pizza-318-1547837614.jpg"
                },
                 new Pizza()
                {
                    Id = 7,
                    Name = "Hawaiian",
                    Size = PizzaSize.Medium,
                    Ingredients = new List<string>(){ "Mozzarella cheese", "Ham", "Pineapple", "Cheese"},
                    Price =  5,
                    ImgUrl = "https://www.jessicagavin.com/wp-content/uploads/2020/07/hawaiian-pizza-16-1200.jpg"
                },
                new Pizza()
                {
                    Id = 8,
                    Name = "Buffalo",
                    Size = PizzaSize.Medium,
                    Ingredients = new List<string>(){ "Cheddar cheese", "Chicken breast", "Provolone cheese", " American cheese", "Red onion"},
                    Price = 5,
                    ImgUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/190226-buffalo-chicken-pizza-370-1552084943.jpg"
                }
            };
        }

        List<Store> IStaticDB.GetStores()
        {
            return new List<Store>()
            {
                new Store()
                {
                    Id = 1,
                    Name = "Dominos",
                    Address = "Street 1",
                    City = "Skopje",
                    PhoneNumber = 1234567891,
                    PizzaIds = new List<int>(){1, 2, 4, 5, 6, 8 }
                },
                new Store()
                {
                    Id = 2,
                    Name = "Figaro",
                    Address =  "Street 2",
                    City = "Skopje",
                    PhoneNumber = 1234567891,
                    PizzaIds = new List<int>(){ 5, 6, 7, 8 }
                },
                new Store()
                {
                    Id = 3,
                    Name = "The Best Pizzas",
                    Address = "Street 3",
                    City = "Skopje",
                    PhoneNumber = 1234567891,
                    PizzaIds = new List<int>(){1, 2, 3 }
                },
                new Store()
                {
                    Id = 4,
                    Name = "Pizza Corner",
                    Address = "Street 4",
                    City = "Skopje",
                    PhoneNumber = 1234567891,
                    PizzaIds = new List<int>(){1, 4, 7, 8}
                },
                new Store()
                {
                    Id = 5,
                    Name = "Pizza INN",
                    Address = "Street 5",
                    City = "Skopje",
                    PhoneNumber = 1234567891,
                    PizzaIds = new List<int>(){1, 2, 3, 4, 5, 7, 8 }
                }
            };
        }

        List<User> IStaticDB.GetUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    Id = 0,
                    FirstName = "Julian",
                    LastName = "Julsky",
                    Address = "Jul Street",
                    PhoneNumber = 080012318888,
                    Email = "admin@yahoo.com",
                    Password = "Admin123$",
                    isAdmin = true
                },
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Bob Street",
                    PhoneNumber = 080012312345,
                    Email = "bob@yahoo.com",
                    Password = "Bob123$",
                    isAdmin = false
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Bobby",
                    LastName = "Bobs",
                    Address = "Bobby Street",
                    PhoneNumber = 080012888896,
                    Email = "bobby@yahoo.com",
                    Password = "Bobby1234$",
                    isAdmin = false
                },
                new User()
                {
                    Id = 3,
                    FirstName = "John",
                    LastName =  "Doe",
                    Address = "John Street",
                    PhoneNumber = 080012388333,
                    Email = "john@yahoo.com",
                    Password = "John12345$",
                    isAdmin = false
                },
                new User()
                {
                    Id = 4,
                    FirstName = "Jeny",
                    LastName = "Juls",
                    Address = "Jeny Street",
                    PhoneNumber = 080012374444,
                    Email = "jeny@yahoo.com",
                    Password = "Jeny123456$",
                    isAdmin = false
                },
                new User()
                {
                    Id = 5,
                    FirstName = "Mark",
                    LastName = "Markus",
                    Address = "Mark Street",
                    PhoneNumber = 080012175111,
                    Email = "mark@yahoo.com",
                    Password = "Mark1234567$",
                    isAdmin = false
                },
                    new User()
                {
                    Id = 6,
                    FirstName = "Dan",
                    LastName = "Dansky",
                    Address = "Dan Street",
                    PhoneNumber = 080012175177,
                    Email = "dan@yahoo.com",
                    Password = "Dan12345678$",
                    isAdmin = false
                },
                new User()
                {
                    Id = 7,
                    FirstName = "Pol",
                    LastName = "Polsky",
                    Address = "Pol Street",
                    PhoneNumber = 080012175777,
                    Email = "pol@yahoo.com",
                    Password = "Pol123456789$",
                    isAdmin = false
                },
                new User()
                {
                    Id = 8,
                    FirstName = "Pirs",
                    LastName ="Pirsky",
                    Address = "Pirs Street",
                    PhoneNumber = 080012175883,
                    Email = "pirs@yahoo.com",
                    Password = "Pirs1234567891$",
                    isAdmin = false
                }
            };
        }
    }
}
