using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnum = randomGenerator.Next(1, 11);

        bool correct = false;

        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessnum = int.Parse(guess);

            if (guessnum > magicnum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessnum < magicnum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                correct = true;
            }
        } while (correct == false);
    }
}