using System;

class Program
{
    static void Main()
    {
        Console.Title = "Rozwiązywanie układu równań z 6 współczynników";
        double a, b, c, d, e, f;

        Console.Write("Podaj a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj c: ");
        c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj d: ");
        d = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj e: ");
        e = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj f: ");
        f = Convert.ToDouble(Console.ReadLine());

        double wyznacznik = a * e - d * b;
        Console.WriteLine($"wyznacznik = {wyznacznik}");

        if (wyznacznik == 0)
        {
            Console.WriteLine("Brak rozwiazan");
        }
        else
        {
            double x0 = (c * e - b * f) / wyznacznik;
            double y0 = (a * f - c * d) / wyznacznik;

            Console.WriteLine($"x0 = {x0}, y0 = {y0}");
        }
    }
}