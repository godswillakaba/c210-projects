using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, enter 0 when you finish");


        int digit = -1;
        do 
        {
            Console.Write("Enter a number..");
            string input = Console.ReadLine();
            digit = int.Parse(input);

            if (digit != 0)
            {
                numbers.Add(digit);
            } 
        }while (digit != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = (float)sum / numbers.Count;

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}