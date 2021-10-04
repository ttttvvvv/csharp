using System;

namespace eindopdracht
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while ("J" == "J")
            {
                Console.WriteLine("Welke opties wil je kiezen?", "<br>");
                Console.WriteLine("1: Inkopers", "<br>");
                Console.WriteLine("2: Verkopers", "<br>");
                Console.WriteLine("3: Manager", "<br>");

                //string optie1 = ;
                int Inkopers = 1;
                int Verkopers = 2;
                int Manager = 3;
                int Keuze1 = 0;


                string[] medewerkersInkoop = new string[] { "1: Bob de Jong ", "2: Jan Overhand" };
                string[] medewerkersVerkoop = new string[] { "1: Rogier de Wit", "2: Sem Oldenhout", "3: Hans de Groot" };
                string[] medewerkersManager = new string[] { "De enige echte manager van de eeuw John van de Heuvel " };
                string[] vasteKlanten = new string[] { "Sara den Ouden", "Olivier Zwart" };

                // int Keuze = int.Parse(Console.ReadLine());

                string input = Console.ReadLine();

                Keuze1 = Int32.Parse(input);


                if (Keuze1 == Inkopers)
                {
                    Console.WriteLine(medewerkersInkoop[0]);
                    Console.WriteLine(medewerkersInkoop[1]);

                }



                else if (Keuze1 == Verkopers)
                {

                    Console.WriteLine(medewerkersVerkoop[0]);
                    Console.WriteLine(medewerkersVerkoop[1]);
                    Console.WriteLine(medewerkersVerkoop[2]);
                }



                else if (Keuze1 == Manager)
                {
                    Console.WriteLine(medewerkersManager[0]);


                }

            
                Console.WriteLine("Wil je terug? [J of N]");
                string answer = Console.ReadLine().ToUpper();


                if (answer == "J")
                {
                    continue;

                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }
    }
}
