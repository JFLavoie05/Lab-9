using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatNamespace
{
    class Chat
    {
        public string Nom { get; set; }
        public string MeilleurCopain { get; set; }
        public bool Humeur { get; set; }
        public Chat(string nom, bool humeur)
        {
            Nom = nom;
            MeilleurCopain = "personne";
            Humeur = humeur;
        }

        public void ChangerMeilleurCopain(string copain)
        {
            MeilleurCopain = copain;
        }
    }
}
