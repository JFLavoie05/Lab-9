using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChienNamespace;
using ChatNamespace;
  

namespace AmitieNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Chien dog = new Chien("Dog");
            Chien doggy = new Chien("Doggy");

            Chat cat = new Chat("Cat", false);

            if (cat.Humeur == false)
            {
            }
            else
            {
                dog.ChangerMeilleurCopain(cat.Nom);
                cat.ChangerMeilleurCopain(dog.Nom);
                doggy.ChangerMeilleurCopain(dog.Nom);
                dog.ChangerMeilleurCopain(doggy.Nom);
                cat.ChangerMeilleurCopain("personne");
            }

            Console.WriteLine($"Le meilleur ami de {cat.Nom} est {cat.MeilleurCopain}\nLe meilleur ami de {dog.Nom} est {dog.MeilleurCopain}\nLe meilleur ami de {doggy.Nom} est {doggy.MeilleurCopain}");

        }
    }
}
