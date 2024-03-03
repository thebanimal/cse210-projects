using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter a number: ");
            string numberString = Console.ReadLine();
            number = int.Parse(numberString);

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = 0;

        foreach (int x in numbers)
        {
            sum = sum + x;
        }
        
        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int highest = numbers[0];

        foreach (int y in numbers)
        {
            if (y > highest)
            {
                highest = y;
            }
        }

        Console.WriteLine($"The largest number is {highest}");
    }
}