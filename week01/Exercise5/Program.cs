using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to my program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();

        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favnum = int.Parse(Console.ReadLine());

        return favnum;
    }

    static int SquareNumber(int number)
    {
        int sqaurednum = number * number;

        return sqaurednum;
    }

    static void DisplayResult(string username, int squarednum)
    {
        Console.WriteLine($"{username}, the square of your favorite number is {squarednum}");
    }
}