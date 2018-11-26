using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAllConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Index();
        }

        static public void Index()
        {
            opdracht opdr = new opdracht();
            List<Action> list = new List<Action>();

            list.Add(() => opdracht.Opdr1());
            list.Add(() => opdracht.Opdr2());
            list.Add(() => opdracht.Opdr3());
            list.Add(() => opdracht.Opdr4());
            list.Add(() => opdracht.Opdr5());
            list.Add(() => opdracht.Opdr6());
            list.Add(() => opdracht.Opdr7());


            Console.WriteLine("Voer getal in");
            Console.WriteLine("0 = Hello world");
            Console.WriteLine("1 = Naam en leeftijd");
            Console.WriteLine("2 = Leeftijd verschil");
            Console.WriteLine("3 = Omtrek rechthoek");
            Console.WriteLine("4 = Reken 85:17");
            Console.WriteLine("5 = Graden naar Fahrenheit");
            Console.WriteLine("6 = Grootste getal bepalen");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 1 && a <= 6)
            {
               list[a]();
               Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Deze index bestaat niet.");
                Console.ReadKey();
            }

            
        }

    }
    }

