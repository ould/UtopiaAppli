using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestHebergeurs.Models
{
    public class Hebergeurs
    {

        public string Nom { get; set; }
        public string AdresseEmail { get; set; }
        public bool NLHC { get; set; }
        public bool Actif { get; set; }
        public DateTime? DateActivation { get; set; }
        public string FrequenceHebergement { get; set; }

        public List<JoursDeLaSemaine> JoursPreference { get; set; }



        public IEnumerable<Disponibilite> Disponibilites { get; set; }

    }



}
