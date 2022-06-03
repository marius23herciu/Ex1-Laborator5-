using System;

namespace Ex1_Laborator5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            //Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
            //siruri de caractere fiind citite de la tastatura

            Console.WriteLine("Introduceti primul sir.");
            string sir1 = CitesteSir();
            Console.WriteLine("Introduceti al doilea sir.");
            string sir2 = CitesteSir();

            if (!sir1.Contains(sir2) && !sir2.Contains(sir1))
            {
                Console.WriteLine("Nici unul din sirurile introduse nu este un substring pentru celalalt.");
                return;
            }

            int pozitie = PozitieSubstring(sir1, sir2);
            Console.WriteLine($"Substringul incepe la pozitia {pozitie}", pozitie);
        }

        static string CitesteSir()
        {
            string sir = Console.ReadLine();
            return sir;
        }
        static int PozitieSubstring(string sir1, string sir2)
        {
            int pozitie=0;
            if (sir2.Length==sir1.Length)
            {
                return pozitie;
            }
            if (sir1.Length>sir2.Length)
            {
                pozitie= sir1.IndexOf(sir2);
            }
            else
            {
                pozitie = sir2.IndexOf(sir1);
            }
            return pozitie;
        }
    }
}
