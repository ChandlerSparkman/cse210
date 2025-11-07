using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        List<int> numbers = new List<int>();
        int num = -1;
        float sum = 0;
        int largest = -1;
        do
        {
            Console.Write("Enter Number: ");
            string input = Console.ReadLine();

            num = int.Parse(input);
            if (num != 0)
            {
                numbers.Add(num);
            }

            if (num > largest)
            {
                largest = num;
            }
            sum = sum + num;

        } while (num != 0);

        float len = numbers.Count;
        float avg = sum / len;

        Console.WriteLine($"The total sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}