using System;
class Program
{
    static void Main()
    {
        Console.Title = "Sprawdzanie, czy tekst jest palindromem";

        Console.Write("Wpisz wyraz: ");
        string wyraz = Console.ReadLine();
        string zaryw = string.Empty;    //ten string będzie przechowywać nasz wyraz pisany od tyłu, sama nazwa to "wyraz", ale od tyłu.

        foreach (char c in wyraz)
        {
            zaryw = c + zaryw;      //wypisywanie wyrazu od tyłu.
        }
        if (wyraz.ToLower() == zaryw.ToLower())     //program porównuje te dwa słowa w małych literach, ponieważ mała i duża litera nie jest taka sama (np. kAjak nie byłby palindromem).
        {
            Console.WriteLine($"{wyraz} jest palindromem.");
        }
        else
        {
            Console.WriteLine($"{wyraz} nie jest palindromem.");
        }
    }
}

/*
 * 
 * Wpisz wyraz:
 * wyraz = 'wpisane słowo'
 * zaryw = null
 * 
 * dla każdego znaku w wyrazie
 *      zaryw = znak + zaryw
 * jeżeli wyraz w małych literach = zaryw w małych literach
 *      'wpisane słowo' jest palindromem.
 * w innym wypadku
 *      'wpisane słowo' nie jest palindromem.
 * 
 */