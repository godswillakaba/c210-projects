// See https://aka.ms/new-console-template for more information
using System;
class Program {
    static void Main()
    {
        string name = "marble";
        string colour = "ash";
        float weight = 45;
        Console.WriteLine($"The rock is {name} and it's colour is {colour}. It weighs {weight}kg");

        int number = 4;
        number += 28;
        number *= 12;
        Console.WriteLine(number);

        Console.Write("What are their names?");
        string names = Console.ReadLine();



    }
}
