//For creativity, I had the program randomly select from three scriptures.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("1 Nephi", 2, 15), "And my father dwelt in a tent."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding.")
        };

        Random random = new Random();
        Scripture selected = scriptures[random.Next(scriptures.Count)];

        bool isCompletelyHidden = selected.getHiddenState();
        while (isCompletelyHidden == false)
        {
            Console.Clear();
            Console.WriteLine(selected.GetDisplayText());
            Console.Write("Enter 'QUIT' to quit, or anything else to hide random words: ");
            string command = Console.ReadLine();

            if (command == "QUIT")
            {
                break;
            }

            selected.HideRandomWords(3);
            isCompletelyHidden = selected.getHiddenState();
        }
    }
}
