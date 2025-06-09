using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Równanie liniowe";
        Console.Write("Podaj a: ");
        double a = Double.Parse(Console.ReadLine());
        Console.Write("Podaj b: ");
        double b = Double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("a nie może być równe 0!");
        }
        else
        {
            double x0 = -b / a;
            Console.WriteLine(x0);
        }
    }
}