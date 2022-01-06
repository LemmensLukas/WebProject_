using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.ViewModel
{
    public class CreateTrainingViewModel
    {
        [Required(ErrorMessage = "Datum moet altijd ingevuld zijn")]
        public string Datum { get; set; }
        [Required(ErrorMessage = "Locatie moet altijd ingevuld zijn")]
        public string Locatie { get; set; }
        [Required(ErrorMessage = "AantalBeschikbareVelden moet altijd ingevuld zijn")]
        public int AantalBeschikbareVelden { get; set; }
        [Required(ErrorMessage = "TrainingsDuur moet altijd ingevuld zijn")]
        public string TrainingsDuur { get; set; }

        public int LeeftijdCategorieId { get; set; }
    }
}
