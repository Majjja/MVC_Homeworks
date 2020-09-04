using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.Models.ViewModels
{
    public class StoreVM
    {
        [HiddenInput(DisplayValue =false)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long PhoneNumber { get; set; }

        [Display(Name = "Pizza Menu")]
        public List<int> PizzaIds { get; set; }

        public StoreVM()
        {

        }
        public StoreVM(int id, string name, string address, string city, long phone, List<int> pizzaids)
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
