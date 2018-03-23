using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace shops.Models
{
    public class ShopDbInitializer : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext db)
        {
            db.Shops.Add(new Shop { Name = "Цветочный", Address = "ул. Сурганова, 46", Mode = "9:00 - 15:00" });
            db.Shops.Add(new Shop { Name = "5 элемент", Address = "пр. Независимости, 54", Mode = "9:00 - 18:00" });
            db.Shops.Add(new Shop { Name = "Магазиныч#3", Address = "ул. Я.Коласа, 21", Mode = "10:00 - 17:00" });

            db.Products.Add(new Product
            {
                Name = "Гладиолус",
                ShopId = 1,
                Description = "Растения многолетние, клубнелуковичные. Стебли вертикальные, неветвящиеся, одиночные, облиственелые, 50-150 см высотой. Листья линейные или мечевидные 50-80 см длиной."
            });
            db.Products.Add(new Product
            {
                Name = "Бегония коралловая",
                ShopId = 1,
                Description = "Крупное кустовидное растение с прямостоячими стеблями. Листья удлиненно-яйцевидной формы, заостренные на конце, с зубчатым краем, до 15 см длиной. Поверхность листа зеленого цвета с белыми вкраплениями или пятнышками. Цветки ярко-розовые собраны в многоцветковые соцветия кисть."
            });
            db.Products.Add(new Product
            {
                Name = "Драцена Сандера",
                ShopId = 1,
                Description = "Компактное растение, вырастающее до 70-100 см в высоту. Имеет серо-зеленые, слегка перекрученные листья, длиной до 23 см. Есть сорт с темно-зеленой каймой."
            });

            db.Products.Add(new Product
            {
                Name = "iPhone X",
                ShopId = 2,
                Description = "Дата выпуска: сентябрь 2017 г."
            });
            db.Products.Add(new Product
            {
                Name = "Samsung Galaxy S9",
                ShopId = 2,
                Description = "Дата выпуска: 2018 г."
            });
            db.Products.Add(new Product
            {
                Name = "Электрогитара",
                ShopId = 2,
                Description = "Разновидность гитары с электромагнитными звукоснимателями, преобразующими колебания металлических струн в колебания электрического тока."
            });

            db.Products.Add(new Product
            {
                Name = "Апельсин",
                ShopId = 3,
                Description = "Вкусный фрукт."
            });
            db.Products.Add(new Product
            {
                Name = "Капуста",
                ShopId = 3,
                Description = "Полезный овощ."
            });
            db.Products.Add(new Product
            {
                Name = "Томат",
                ShopId = 3,
                Description = "Синьор Помидор."
            });

            base.Seed(db);
        }
    }
}