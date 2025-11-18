using System;

class Program
{
    static void Main()
    {
        Console.Title = "Sprawdzanie, czy liczba jest liczbą pierwszą";
        Console.Write("Podaj liczbę: ");
        int liczba = int.Parse(Console.ReadLine());

        if (liczba <= 1)
        {
            Console.WriteLine(liczba + " nie jest liczbą pierwszą");
            return;
        }

        if (liczba == 2 || liczba == 3)
        {
            Console.WriteLine(liczba + " jest liczbą pierwszą");
            return;
        }

        if (liczba % 2 == 0 || liczba % 3 == 0)
        {
            Console.WriteLine(liczba + " nie jest liczbą pierwszą");
            return;
        }

        for (int i = 5; i * i <= liczba; i += 6)
        {
            if (liczba % i == 0 || liczba % (i + 2) == 0)
            {
                Console.WriteLine(liczba + " nie jest liczbą pierwszą");
                return;
            }
        }

        Console.WriteLine(liczba + " jest liczbą pierwszą");
    }
}