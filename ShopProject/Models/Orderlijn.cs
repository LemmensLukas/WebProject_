using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models
{
    public class Orderlijn
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int productId { get; set; }
        public Product product { get; set; }
        public int Hoeveelheid { get; set; }
        public Decimal TotaalPrijs { get; set; }
    }
}
