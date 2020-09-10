﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.Models.DomainModels
{
    public class Order
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int UserId { get; set; }
        public int PizzaId { get; set; }
        public bool IsDelivered { get; set; }

    }
}
