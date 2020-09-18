
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.DataAccess.ViewModels
{
    public class StoreVM
    {
        //[HiddenInput(DisplayValue =false)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long PhoneNumber { get; set; }

        [Display(Name = "Pizza Menu")]
        public List<PizzaVM> ListOfPizzas { get; set; }
    }
}
