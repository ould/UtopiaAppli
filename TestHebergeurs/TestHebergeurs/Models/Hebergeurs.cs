using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestHebergeurs.Models
{
    public class Hebergeurs
    {

        public string Nom { get; set; }
        //public string Prenom { get; set; }
        public string AdresseEmail { get; set; }

        public List<JoursDeLaSemaine> JoursPreference { get; set; }


        public IEnumerable<Disponibilite> Disponibilites { get; set; }

    }



}
