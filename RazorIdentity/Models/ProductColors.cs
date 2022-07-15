using System;
using System.Collections.Generic;

namespace RazorIdentity.Models
{
    public partial class ProductColors
    {
        public ProductColors()
        {
            Products = new HashSet<Products>();
        }

        public int ProductColorId { get; set; }
        public string Color { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
