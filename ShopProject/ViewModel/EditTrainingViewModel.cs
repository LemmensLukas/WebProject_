using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.ViewModel
{
    public class EditTrainingViewModel
    {
        public int ID { get; set; }

        public string Datum { get; set; }

        public string Locatie { get; set; }

        public int AantalBeschikbareVelden { get; set; }

        public string TrainingsDuur { get; set; }

        public int LeeftijdCategorieId { get; set; }
    }
}
