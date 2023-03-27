using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienNamespace
{
    class Chien
    {
        public string Nom { get; set; }
        public string MeilleurCopain { get; set; }

        public Chien (string nom)
        {
            Nom = nom;
            MeilleurCopain = "personne";
        }

        public void ChangerMeilleurCopain (string copain)
        {
            MeilleurCopain = copain;
        }
    }
}
