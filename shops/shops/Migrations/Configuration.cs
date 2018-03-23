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
                new Shop { Id = 1, Name = "���������", Address = "��. ���������, 46", Mode = "9:00 - 15:00" },
                new Shop { Id = 2, Name = "5 �������", Address = "��. �������������, 54", Mode = "9:00 - 18:00" },
                new Shop { Id = 3, Name = "���������#3", Address = "��. �.������, 21", Mode = "10:00 - 17:00" }
                );

            // Add 3 Products to the 1st Shop
            context.Products.AddOrUpdate(x => x.Id,
                new Product
                {
                    Id = 1,
                    Name = "���������",
                    ShopId = 1,
                    Description = "�������� �����������, ����������������. ������ ������������, ������������, ���������, �������������, 50-150 �� �������. ������ �������� ��� ���������� 50-80 �� ������."
                },
                new Product
                {
                    Id = 2,
                    Name = "������� ����������",
                    ShopId = 1,
                    Description = "������� ����������� �������� � ������������� ��������. ������ ���������-���������� �����, ����������� �� �����, � �������� �����, �� 15 �� ������. ����������� ����� �������� ����� � ������ ������������ ��� ����������. ������ ����-������� ������� � �������������� �������� �����."
                },
                new Product
                {
                    Id = 3,
                    Name = "������� �������",
                    ShopId = 1,
                    Description = "���������� ��������, ����������� �� 70-100 �� � ������. ����� ����-�������, ������ ������������� ������, ������ �� 23 ��. ���� ���� � �����-������� ������."
                });

            // Add 3 Products to the 2nd Shop
            context.Products.AddOrUpdate(x => x.Id,
                new Product
                {
                    Id = 4,
                    Name = "iPhone X",
                    ShopId = 2,
                    Description = "���� �������: �������� 2017 �."
                },
                new Product
                {
                    Id = 5,
                    Name = "Samsung Galaxy S9",
                    ShopId = 2,
                    Description = "���� �������: 2018 �."
                },
                new Product
                {
                    Id = 6,
                    Name = "�������������",
                    ShopId = 2,
                    Description = "������������� ������ � ����������������� ����������������, �������������� ��������� ������������� ����� � ��������� �������������� ����."
                });

            // Add 3 Products to the 3rd Shop
            context.Products.AddOrUpdate(x => x.Id,
                new Product
                {
                    Id = 7,
                    Name = "��������",
                    ShopId = 3,
                    Description = "������� �����."
                },
                new Product
                {
                    Id = 8,
                    Name = "�������",
                    ShopId = 3,
                    Description = "�������� ����."
                },
                new Product
                {
                    Id = 9,
                    Name = "�����",
                    ShopId = 3,
                    Description = "������ �������."
                });
        }
    }
}
