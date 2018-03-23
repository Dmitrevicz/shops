namespace shops.Migrations
{
    using shops.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<shops.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(shops.Models.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // Add 3 Shops
            context.Shops.AddOrUpdate(x => x.Id, 
                new Shop { Id = 1, Name = "Цветочный", Address = "ул. Сурганова, 46", Mode = "9:00 - 15:00" },
                new Shop { Id = 2, Name = "5 элемент", Address = "пр. Независимости, 54", Mode = "9:00 - 18:00" },
                new Shop { Id = 3, Name = "Магазиныч#3", Address = "ул. Я.Коласа, 21", Mode = "10:00 - 17:00" }
                );

            // Add 3 Products to the 1st Shop
            context.Products.AddOrUpdate(x => x.Id,
                new Product
                {
                    Id = 1,
                    Name = "Гладиолус",
                    ShopId = 1,
                    Description = "Растения многолетние, клубнелуковичные. Стебли вертикальные, неветвящиеся, одиночные, облиственелые, 50-150 см высотой. Листья линейные или мечевидные 50-80 см длиной."
                },
                new Product
                {
                    Id = 2,
                    Name = "Бегония коралловая",
                    ShopId = 1,
                    Description = "Крупное кустовидное растение с прямостоячими стеблями. Листья удлиненно-яйцевидной формы, заостренные на конце, с зубчатым краем, до 15 см длиной. Поверхность листа зеленого цвета с белыми вкраплениями или пятнышками. Цветки ярко-розовые собраны в многоцветковые соцветия кисть."
                },
                new Product
                {
                    Id = 3,
                    Name = "Драцена Сандера",
                    ShopId = 1,
                    Description = "Компактное растение, вырастающее до 70-100 см в высоту. Имеет серо-зеленые, слегка перекрученные листья, длиной до 23 см. Есть сорт с темно-зеленой каймой."
                });

            // Add 3 Products to the 2nd Shop
            context.Products.AddOrUpdate(x => x.Id,
                new Product
                {
                    Id = 4,
                    Name = "iPhone X",
                    ShopId = 2,
                    Description = "Дата выпуска: сентябрь 2017 г."
                },
                new Product
                {
                    Id = 5,
                    Name = "Samsung Galaxy S9",
                    ShopId = 2,
                    Description = "Дата выпуска: 2018 г."
                },
                new Product
                {
                    Id = 6,
                    Name = "Электрогитара",
                    ShopId = 2,
                    Description = "Разновидность гитары с электромагнитными звукоснимателями, преобразующими колебания металлических струн в колебания электрического тока."
                });

            // Add 3 Products to the 3rd Shop
            context.Products.AddOrUpdate(x => x.Id,
                new Product
                {
                    Id = 7,
                    Name = "Апельсин",
                    ShopId = 3,
                    Description = "Вкусный фрукт."
                },
                new Product
                {
                    Id = 8,
                    Name = "Капуста",
                    ShopId = 3,
                    Description = "Полезный овощ."
                },
                new Product
                {
                    Id = 9,
                    Name = "Томат",
                    ShopId = 3,
                    Description = "Синьор Помидор."
                });
        }
    }
}
