using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.ViewModel
{
    public class ProductListViewModel
    {
        public string ProductSearch { get; set; }
        public List<Product> Producten { get; set; }
    }
}
