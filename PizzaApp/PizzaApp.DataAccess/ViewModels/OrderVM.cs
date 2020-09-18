using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.DataAccess.ViewModels
{
    public class OrderVM
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int UserId { get; set; }
        public int PizzaId { get; set; }
        public bool IsDelivered { get; set; }
    }
}
