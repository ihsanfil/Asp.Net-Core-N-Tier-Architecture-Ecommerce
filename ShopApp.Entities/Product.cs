using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
   public class Product
    {
        public int Id { get; set; }
        public string DefaultName { get; set; }
        //public string ImageUrl { get; set; }
        //public string Description { get; set; }
        //public string FullDescription { get; set; }
        //public decimal? Price { get; set; }

        //KATEGORİLER
        public List<ProductCategory> ProductCategories { get; set; }
        //DİLLER
        public List<Product_Locale> ProductLocales { get; set; }
    }
}
