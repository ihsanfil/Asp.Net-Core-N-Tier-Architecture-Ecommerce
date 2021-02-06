using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopApp.Entities
{
    public class Product_Locale
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CultureId { get; set; }
        public Culture Cultures { get; set; }

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public decimal? Price { get; set; }


    }
}
