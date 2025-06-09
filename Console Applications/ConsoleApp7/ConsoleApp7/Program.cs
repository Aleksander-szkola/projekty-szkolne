using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Obliczanie wartości bezwzględnej";
        Console.Write("Podaj x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double X = (x < 0) ? -x : x;

        double Y = (y < 0) ? -y : y;

        Console.WriteLine($"Bezwzględna x: {X}");
        Console.WriteLine($"Bezwzględna y: {Y}");
    }
}
