using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAllConsole
{

    class opdracht
    {

        static public void Opdr1()
        {
            Console.Clear();
            Console.WriteLine("Hello world");
            Console.WriteLine("Druk op enter om terug te gaan");
            Console.ReadKey();
            Console.Clear();
            Program.Index();
        }

        static public void Opdr2()
        {
            Console.Clear();
            Console.WriteLine("Wat is je naam?");
            var name = Console.ReadLine();
            Console.WriteLine("Wat is je leeftijd?");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Je naam is {0}. Je leeftijd is {1}", name, leeftijd);

            Console.WriteLine("Druk op enter om terug te gaan");
            Console.ReadKey();
            Console.Clear();
            Program.Index();
        }

        static public void Opdr3()
        {
            Console.Clear();

            Console.WriteLine("Wat is je naam?");
            var name = Console.ReadLine();

            Console.WriteLine("Welkom {0}", name);

            Console.WriteLine("Wat is je leeftijd?");
            int leeftijd = Convert.ToInt32(Console.ReadLine());

            int result = Math.Abs(leeftijd - 50);
            Console.WriteLine("Het verschil in leeftijd tussen jouw en je docent is {0} ", result);

            Console.WriteLine("Druk op enter om terug te gaan");
            Console.ReadKey();
            Console.Clear();
            Program.Index();
        }

        static public void Opdr4()
        {
            Console.Clear();
            Console.WriteLine("Omtrek rechthoek, breedte:");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Omtrek rechthoek, lengte:");
            int H = Convert.ToInt32(Console.ReadLine());

            int result = B * H;

            Console.WriteLine("De omtrek van je rechthoek is {0}", result);
            Console.ReadKey();
            Console.Clear();
            Program.Index();
        }

        static public void Opdr5()
        {
            Console.Clear();
            Console.WriteLine("Wat is 85:17?");
            int ans = Convert.ToInt32(Console.ReadLine());

            if (ans != 5)
            {
                Console.WriteLine("Het antwoord is fout");
                Console.ReadKey();
                Opdr5();
            }
            else
            {
                Console.WriteLine("Het antwoord is goed");
            }

            Console.ReadKey();
            Console.Clear();
            Program.Index();
        }

        static public void Opdr6()
        {
            Console.Clear();
            Console.WriteLine("Voer een waarde in celcius in.");

            int temp = Convert.ToInt32(Console.ReadLine());
            decimal fahrenheit = (temp * (9/5)) + 32;

            Console.WriteLine("De temperatuur in Fahrenheit is {0}", fahrenheit);
            Console.WriteLine("De temperatuur in Graden is {0}", temp);


            Console.WriteLine("Druk op een toets om terug te gaan");
            Console.ReadKey();
            Console.Clear();
            Program.Index();
        }

        static public void Opdr7()
        {
            Console.Clear();

            Console.WriteLine("Voer twee getallen in om de grootste te laten bepalen");

            Console.WriteLine("Getal 1 =");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Getal 2 =");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Het grootste getal is: {0}", Math.Max(getal1, getal2));

            Console.WriteLine("Druk op een toets om terug te gaan");
            Console.ReadKey();
            Console.Clear();
            Program.Index();
        }


    }
}
