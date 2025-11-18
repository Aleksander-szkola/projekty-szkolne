using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Obliczanie potęgi";
        Console.Write("Podaj podstawę: ");
        double podstawa = Double.Parse(Console.ReadLine());

        Console.Write("Podaj wykładnik: ");
        double wykladnik = Double.Parse(Console.ReadLine());

        if (podstawa == 0)
        {
            Console.WriteLine("Podstawa nie może być 0!");
            return;
        }

        double potega = 1;

        if (wykladnik == 0)
        {
            Console.WriteLine($"Wynik: {potega}");
            return;
        }

        double pom = wykladnik;
        while (pom > 0)
        {
            potega *= podstawa;
            pom--;
        }

        Console.WriteLine($"Wynik: {potega}");
    }
}