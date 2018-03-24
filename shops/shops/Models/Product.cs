using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shops.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Название товара")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        public int ShopId { get; set; }

        public virtual Shop Shop { get; set; }
    }
}