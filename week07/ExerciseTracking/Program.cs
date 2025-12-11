using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(30, 5);
        Cycling cycling = new Cycling(40, 20);
        Swimming swimming = new Swimming(25, 30);

        Console.WriteLine(running.GetSummary());
        Console.WriteLine(cycling.GetSummary());
        Console.WriteLine(swimming.GetSummary());
    }
}