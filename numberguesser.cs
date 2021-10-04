using System;


namespace numberguesser
{
    
    class Program
    {
        

        public static void Main(string[] args)
        {
            getappinfo();

             
            Console.WriteLine("Wat is je naam? ");

            
            string inputName = Console.ReadLine();

            Console.WriteLine("Hoi {0}  , zin in een leuk spelletje?", inputName);


            while (true)
            {

                //maak er een random nummer van of een fixed

                //int correctNumber = 7;
                Random random = new Random();

                int correctNumber = random.Next(1, 14);

                //guess var
                int guess = 0;


                
                Console.WriteLine("Raad een nummer tussen 1 en 14 ");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get users input 
                    string input = Console.ReadLine();

                    //zeker weten dat het een nummer is
                    if (!int.TryParse(input, out guess))
                    {
                        //Change Text Color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //tell user wrong input
                        Console.WriteLine("Geef een cijfer op, want dit is een letter");

                        // Reset Test color
                        Console.ResetColor();

                        continue;
                    }
                    //cast to int and put in guess
                    guess = Int32.Parse(input);


                    if (guess != correctNumber)
                    {

                        //Change Text Color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //tell user wrong input
                        Console.WriteLine("verkeerd nummer probeer nog een keer");

                        // Reset Test color
                        Console.ResetColor();
                    }




                }
                //output succes message

                Console.ForegroundColor = ConsoleColor.DarkGreen;

                //writeout app info 
                Console.WriteLine(" Gefeliciteerd {0} dit is het goede nummer je bent geslaagd !!", inputName);

                // Reset Test color
                Console.ResetColor();

                Console.WriteLine("Wil je opnieuw? [J of N]");
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

        static void getappinfo()
        {
            // set vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Tim vd Helm";


            
            Console.ForegroundColor = ConsoleColor.Green;

             
            Console.WriteLine("{0}: Versie {1} door {2}", appName, appVersion, appAuthor);

            // Reset Test color
            Console.ResetColor();
        }
    }


}
