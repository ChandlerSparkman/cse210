using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade percentage did you earn? ");
        string grade = Console.ReadLine();
        int gradenum = int.Parse(grade);

        if (gradenum >= 90)
        {
            Console.WriteLine("You got an A!");
        }
        else if (gradenum >= 80)
        {
            Console.WriteLine("You got a B!");
        }
        else if (gradenum >= 70)
        {
            Console.WriteLine("You got a C!");
        }
        else if (gradenum >= 60)
        {
            Console.WriteLine("You got a D.");
        }
        else
        {
            Console.WriteLine("You got an F.");
        }

        if (gradenum < 70)
        {
            Console.WriteLine("You failed the class. Sorry about that, bud. You got it next time!");
        }
        else
        {
            Console.WriteLine("You passed! Congrats, I knew you could.");
        }
    }
}