using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models
{
    public class ProductCategorie
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategorieId { get; set; }
    }
}
