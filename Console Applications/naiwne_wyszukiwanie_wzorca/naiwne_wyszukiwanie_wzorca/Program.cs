using System;

class Program
{
    static void naiveSearch(string text, string pattern)
    {
        int textLength = text.Length;
        int patternLength = pattern.Length;
        bool found = false;

        for (int i = 0; i <= textLength - patternLength; i++)
        {
            int j;

            for (j = 0; j < patternLength; j++)
            {
                if (text[i + j] != pattern[j]) break;
            }
            if (j == patternLength)
            {
                Console.WriteLine($"Wzorzec znaleziony na pozycji {i + 1}");
                found = true;
            }
        }
        if (!found) Console.WriteLine("Nie znaleziono wzorca");
    }

    static void Main()
    {
        Console.Write("Podaj tekst: ");
        string text = Console.ReadLine();
        Console.Write("Podaj wzorzec: ");
        string pattern = Console.ReadLine();
        naiveSearch(text, pattern);
    }
}
