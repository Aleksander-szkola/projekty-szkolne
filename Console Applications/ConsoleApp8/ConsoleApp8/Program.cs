using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Sprawdzanie która liczba jest większa"
        Console.Write("Podaj a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Podaj b: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"{a} jest większe od {b}");
        }
        else if (b > a)
        {
            Console.WriteLine($"{b} jest większe od {a}");
        }
        else
        {
            Console.WriteLine($"Liczby {a} i {b} są równe");
        }
    }
}