using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nIndtast dit navn :");
            List<string> navne = new List<string>();
            //navne.

            string navn = Console.ReadLine(); // her er alle navne afskildt med "space"
            string[] delnavne = navn.Split(' ');
            string samletNavn = "";
            foreach (string delafnavn in delnavne)

            {
               // Console.WriteLine("Del :" + StortOgSmåt(delafnavn));
                samletNavn += stortOgSmåt(delafnavn) + " ";
            }
            Console.WriteLine(samletNavn);
            Console.ReadLine();

        }
        //metode der modatager del af navn og retunerer delafnavn med stort 1. bogstav og resten småt.
        static string stortOgSmåt(string delnavn)
        {
            return delnavn.Substring(0, 1).ToUpper() + delnavn.Substring(1).ToLower();
        }
    }
}
