﻿
using PizzaApp.DataAccess.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PizzaApp.DataAccess.ViewModels
{
    public class PizzaVM
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Pizza Name:")]
        public string Name { get; set; }

        [Display(Name = "Pizza Size:")]
        public PizzaSize Size { get; set; }

        [Display(Name = "Pizza Ingredients:")]
        public List<string> Ingredients { get; set; }

        [Display(Name = "Pizza Price:")]
        public double Price { get; set; }
        public string ImgUrl { get; set; }
    }
}
