using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using shops.Models;

namespace shops.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private AppDbContext db;

        public ProductRepository(AppDbContext context)
        {
            this.db = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }

        public Product FindById(int id)
        {
            return db.Products.Find(id);
        }

        public void Create(Product product)
        {
            db.Products.Add(product);
        }

        public void Update(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null)
                db.Products.Remove(product);
        }

        // get product's list of chosen shop by ShopId
        public IQueryable<Product> GetQueryableById(int id)
        {
            return db.Products.Where(x => x.ShopId == id);
        }
    }
}