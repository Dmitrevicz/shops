using shops.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace shops.Repository
{
    public class ShopRepository : IRepository<Shop>
    {
        private AppDbContext db;

        public ShopRepository(AppDbContext context)
        {
            this.db = context;
        }

        public IEnumerable<Shop> GetAll()
        {
            return db.Shops;
        }

        public Shop FindById(int id)
        {
            return db.Shops.Find(id);
        }

        public void Create(Shop shop)
        {
            db.Shops.Add(shop);
        }

        public void Update(Shop shop)
        {
            db.Entry(shop).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Shop shop = db.Shops.Find(id);
            if (shop != null)
                db.Shops.Remove(shop);
        }
    }
}