// For creativity, I created a stylized ascii menu, added a random activity option, and made the reflection activity not use repeat questions.

using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        Random random = new Random();

        bool quit = false;

        while (quit == false)
        {
            Console.Clear();
            Console.WriteLine(" -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- ");
            Console.WriteLine("| 1 - Breathing Activity - Duration: 40 Seconds                                                                                                                                                                |");
            Console.WriteLine("| This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.                                                                          |");
            Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("| 2 - Reflection Activity - Duration: 50 Seconds                                                                                                                                                               |");
            Console.WriteLine("| This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. |");
            Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("| 3 - Listing Activity - Duration: 70 Seconds                                                                                                                                                                  |");
            Console.WriteLine("| This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.                                                                          |");
            Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("| 4 - Random Activity - Duration: ??? Seconds                                                                                                                                                                  |");
            Console.WriteLine("| Select randomly from the above activities.                                                                                                                                                                   |");
            Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("| 5 - Quit                                                                                                                                                                                                     |");
            Console.WriteLine("| Quits the program.                                                                                                                                                                                           |");
            Console.WriteLine(" -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- ");

            Console.Write("Enter Command: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                breathingActivity.Run();
            }
            else if (userInput == "2")
            {
                reflectionActivity.Run();
            }
            else if (userInput == "3")
            {
                listingActivity.Run();
            }
            else if (userInput == "4")
            {
                int chosenActivity = random.Next(1, 4);

                if (chosenActivity == 1)
                {
                    breathingActivity.Run();
                }
                else if (chosenActivity == 2)
                {
                    reflectionActivity.Run();
                }
                else if (chosenActivity == 3)
                {
                    listingActivity.Run();
                }
            else if (userInput == "5")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("ERROR: Command not recognized. Be sure to only enter the number of the command you'd like to execute. Enter anything to return to menu.");
                Console.ReadLine();
            }
        }
    }
}}