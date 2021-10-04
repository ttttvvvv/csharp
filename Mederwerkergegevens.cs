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
                printKleur(ConsoleColor.Green, "1: Inkopers");
                
                printKleur(ConsoleColor.Red, "2: Verkopers");
                
                printKleur(ConsoleColor.Blue, "3: Managers");

                printKleur(ConsoleColor.Yellow, "4: Klanten");

                //Console.WriteLine("1: Inkopers", "<br>");
                // Console.WriteLine("2: Verkopers", "<br>");
                //Console.WriteLine("3: Manager", "<br>");

                //string optie1 = ;
                int Inkopers = 1;
                int Verkopers = 2;
                int Manager = 3;
                int klanten = 4;
                int Keuze1 = 0;


                string[] medewerkersInkoop = new string[] { "1: Bob de Jong ", "2: Jan Overhand" };
                string[] medewerkersVerkoop = new string[] { "1: Rogier de Wit", "2: Sem Oldenhout", "3: Hans de Groot" };
                string[] medewerkersManager = new string[] { "De manager van de Eeuw: John van de Heuvel " };
                string[] vasteKlanten = new string[] { "Klant 1: Sara den Ouden", "Klant 2: Olivier Zwart", "Klant 3: Achmed Bizou", "Klant 4: Erik Hogendam", "Klant 5: Zakaria Zizou", "Klant 6: Mr-Anonomous", "Klant 7: Anoniem", "Klant 8: Michiel van Velden", "Klant 9: Michelle Everdeen" };
                
                // int Keuze = int.Parse(Console.ReadLine());

                string input = Console.ReadLine();

                Keuze1 = Int32.Parse(input);


                if (Keuze1 == Inkopers)
                {
                    printKleur(ConsoleColor.Green, "Inkopers");
                    Console.WriteLine(medewerkersInkoop[0]);
                    Console.WriteLine(medewerkersInkoop[1]);

                }



                else if (Keuze1 == Verkopers)
                {
                    printKleur(ConsoleColor.Red, "Verkopers");
                    printKleur(ConsoleColor.White, medewerkersVerkoop[0]);
                    //Console.WriteLine(medewerkersVerkoop[0]);
                    Console.WriteLine(medewerkersVerkoop[1]);
                }



                else if (Keuze1 == Manager)
                {
                    printKleur(ConsoleColor.Blue, "Managers");
                    Console.WriteLine(medewerkersManager[0]);


                }
                else if (Keuze1 == klanten)
                {
                    printKleur(ConsoleColor.Yellow, "Klanten");
                    Console.WriteLine(vasteKlanten[0]);
                    Console.WriteLine(vasteKlanten[1]);
                    Console.WriteLine(vasteKlanten[2]);
                    Console.WriteLine(vasteKlanten[3]);
                    Console.WriteLine(vasteKlanten[4]);
                    Console.WriteLine(vasteKlanten[5]);
                    Console.WriteLine(vasteKlanten[6]);
                    Console.WriteLine(vasteKlanten[7]);
                    Console.WriteLine(vasteKlanten[8]);
                    //Console.WriteLine(vasteKlanten[9]);

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
        static void printKleur(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
