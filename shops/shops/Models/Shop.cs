using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shops.Models
{
    public class Shop
    {
        public int Id { get; set; }

        [Display(Name = "Название магазина")]
        public string Name { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Режим работы")]
        public string Mode { get; set; } // Mode of operation

        public virtual ICollection<Product> Products { get; set; }

        public Shop()
        {
            Products = new List<Product>();
        }
    }
}