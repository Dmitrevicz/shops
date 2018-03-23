using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shops.Models
{
    public class Shop
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Mode { get; set; } // Mode of operation

        public virtual ICollection<Product> Products { get; set; }

        public Shop()
        {
            Products = new List<Product>();
        }
    }
}