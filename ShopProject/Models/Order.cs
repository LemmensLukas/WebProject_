using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int klantId { get; set; }
        public DateTime Datum { get; set; }
        public DateTime GeleverdeDatum { get; set; }
        public Klant Klant { get; set; }
    }
}
