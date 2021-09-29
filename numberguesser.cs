using System;


namespace numberguesser
{
    
    class Program
    {
        

        public static void Main(string[] args)
        {
            // set vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Tim vd Helm";


            
            Console.ForegroundColor = ConsoleColor.Green;

            //app informatie
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            
            Console.ResetColor();

            
            Console.WriteLine("What is your name? ");

            
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}  ,lets play a little funny game", inputName);
        

        

            //correct int
            int correctNumber = 7;
            //guess var
            int guess = 0;


             
           Console.WriteLine("Guess a number between 1 and 10 ");

            //while guess is not correct
            while (guess != correctNumber)
            {
                //get users input 
                string input = Console.ReadLine();

                //cast to int and put in guess
               guess = Int32.Parse(input);


                if (guess != correctNumber)
                {

                    
                    Console.ForegroundColor = ConsoleColor.Red;

                    //tell user wrong input
                    Console.WriteLine("verkeerd nummer probeer nog een keer");

                    
                    Console.ResetColor();
                }


        
                
            }
            //output succes message

            Console.ForegroundColor = ConsoleColor.Blue;

            
            Console.WriteLine("Goedzo je bent geslaagd !!");

            
            Console.ResetColor();
        }
    }

       
                
}
