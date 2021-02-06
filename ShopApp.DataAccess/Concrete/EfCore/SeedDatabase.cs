using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Cultures.Count() == 0)
                {
                    context.Cultures.AddRange(Cultures);
                }
                if (context.Products.Count() <= 4)
                {
                    context.Products.AddRange(Products);

                    context.AddRange(ProductLocale);
                    context.AddRange(ProductCategory);
                }
               

                context.SaveChanges();
            }
        }

        private static Category[] Categories =     {
            new Category() { Name="Telefon"},
            new Category() { Name="Bilgisayar"},
            new Category() { Name="Elektronik"}
        };

        private static Product[] Products =
        {
            //BOŞ DEĞER OLUSTURDUK PRODUCT OLUŞSUN Kİ AŞAĞIDA DEĞER GİREBİLELİM !
            new Product(){DefaultName=""},
            new Product(){DefaultName=""},
            new Product(){DefaultName=""},
            new Product(){DefaultName=""},
            new Product(){DefaultName=""}

        };
        private static Culture[] Cultures = {
            new Culture(){ CultureName = "Turkish" },
            new Culture(){ CultureName = "English" },
            new Culture(){ CultureName = "German" }
        };
        private static Product_Locale[] ProductLocale = {

            new Product_Locale(){ProductId=1,CultureId=1,Name="Samsung S5", Price=2000, ImageUrl="1.jpg", Description="<p>güzel telefon</p>"},
            new Product_Locale(){ProductId=1,CultureId=2,Name="Samsung S5", Price=3000, ImageUrl="2.jpg", Description="<p>güzel telefon</p>"},
            new Product_Locale(){ProductId=1,CultureId=3,Name="Samsung S5", Price=4000, ImageUrl="3.jpg", Description="<p>güzel telefon</p>"},
            new Product_Locale(){ProductId=2,CultureId=1,Name="Samsung S5", Price=5000, ImageUrl="4.jpg", Description="<p>güzel telefon</p>"},
            new Product_Locale(){ProductId=3,CultureId=1,Name="Samsung S5", Price=6000, ImageUrl="5.jpg", Description="<p>güzel telefon</p>"},
            new Product_Locale(){ProductId=4,CultureId=1,Name="Samsung S5", Price=7000, ImageUrl="6.jpg", Description="<p>güzel telefon</p>"}

        };
        private static ProductCategory[] ProductCategory =
        {
            new ProductCategory() { Product= Products[0],Category= Categories[0]},
            new ProductCategory() { Product= Products[0],Category= Categories[2]},
            new ProductCategory() { Product= Products[1],Category= Categories[0]},
            new ProductCategory() { Product= Products[1],Category= Categories[1]},
            new ProductCategory() { Product= Products[2],Category= Categories[0]},
            new ProductCategory() { Product= Products[2],Category= Categories[2]},
            new ProductCategory() { Product= Products[3],Category= Categories[1]}
        };
    }
}
