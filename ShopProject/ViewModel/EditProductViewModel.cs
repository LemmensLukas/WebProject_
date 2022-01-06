using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.ViewModel
{
    public class EditProductViewModel
    {
        public int productId { get; set; }
        public string Naam { get; set; }
        public int EenhedenInVoorraad { get; set; }
        public int EenhedenInBestelling { get; set; }
        public string productBeschrijving { get; set; }
        public DateTime InCatalogus { get; set; }
        public Decimal Prijs { get; set; }
        public int categorieId { get; set; }
    }
}
