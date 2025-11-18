using System;
class Program
{
    static void Main()
    {
        Console.Title = "Sprawdzanie, czy tekst jest palindromem";

        Console.Write("Wpisz wyraz: ");
        string wyraz = Console.ReadLine();
<<<<<<< HEAD
        string zaryw = string.Empty;    //ten string będzie przechowywać nasz wyraz pisany od tyłu, sama nazwa to "wyraz", ale od tyłu.

        foreach (char c in wyraz)
        {
            zaryw = c + zaryw;      //wypisywanie wyrazu od tyłu.
        }
        if (wyraz.ToLower() == zaryw.ToLower())     //program porównuje te dwa słowa w małych literach, ponieważ mała i duża litera nie jest taka sama (np. kAjak nie byłby palindromem).
=======
        string zaryw = string.Empty;

        foreach (char c in wyraz)
        {
            zaryw = c + zaryw;
        }
        if (wyraz.ToLower() == zaryw.ToLower())
>>>>>>> 10cf5940fb27aec9e6b52bb6d2a5b8142cc85bee
        {
            Console.WriteLine($"{wyraz} jest palindromem.");
        }
        else
        {
            Console.WriteLine($"{wyraz} nie jest palindromem.");
        }
    }
<<<<<<< HEAD
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
=======
}
>>>>>>> 10cf5940fb27aec9e6b52bb6d2a5b8142cc85bee
