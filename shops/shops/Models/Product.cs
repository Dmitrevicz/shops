using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shops.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ShopId { get; set; }

        public virtual Shop Shop { get; set; }
    }
}