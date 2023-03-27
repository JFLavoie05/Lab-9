using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Drawing;
using Console = Colorful.Console;
using Figgle;

namespace Humanizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestHumain();
            TestConsole();
           
        }



        static void TestHumain()
        {

            string message1 = "Bonjour, je suis un étudiant en informatique.";
            string message2 = "Ce texte est réellement long, il faudrait le réduire s'il vous plait";
            string message3 = "bonjour, bonsoir, salut, aurevoir";
            string message4 = "Non, oui, no, yes";

            Console.WriteLine(message1.ToUpper());
            Console.WriteLine(message2.Truncate(30));
            Console.WriteLine(message1.Transform(To.LowerCase));
            Console.WriteLine(message3.Transform(To.TitleCase));
            Console.WriteLine(message4.Humanize());
           
        }

        static void TestConsole()
        {
            string message1 = "Ce message est en couleur";
            Colorful.Figlet figlet = new Colorful.Figlet();
            

            Console.WriteLine("\n\n\n" + message1, Color.DarkBlue);
            Console.WriteLine(message1, Color.Goldenrod);
            Console.WriteAscii(message1, Color.Pink);
            Console.WriteLine(figlet.ToAscii(message1), ColorTranslator.FromHtml("#8AFFEF"));
            Console.WriteLine(message1, Color.YellowGreen);
        }
    }
}
