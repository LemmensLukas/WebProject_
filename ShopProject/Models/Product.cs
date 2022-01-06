using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models
{
    public class Product
    {
        public int productId { get; set; }

        [Required(ErrorMessage = "Naam moet altijd ingevuld zijn")]
        public string Naam { get; set; }
        public int EenhedenInVoorraad { get; set; }
        public int EenhedenInBestelling { get; set; }
        public string productBeschrijving { get; set; }

        [DataType(DataType.Date)]
        public DateTime InCatalogus { get; set; }

        [Required(ErrorMessage = "Prijs moet altijd ingevuld zijn")]
        public Decimal Prijs { get; set; }
        public int categorieId { get; set; }
    }
}
