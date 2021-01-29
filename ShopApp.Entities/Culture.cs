using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopApp.Entities
{
    public class Culture
    {
        public int CultureId { get; set; }
        [Required]
        public string CultureName { get; set; }
        public string CultureIcon { get; set; }
        public string DisplayOrder { get; set; }
    }
}
