using System;

class BOGO_SORT
{
    private static bool JestPosortowana(ref int[] tab)
    {
        int c = tab.Length;

        while (--c >= 1)
        {
            if (tab[c] < tab[c - 1])
                return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        Random rand = new Random();
        Console.WriteLine("Tablica przed sortowaniem:");

        foreach (int liczba in a)
        {
            Console.Write($"{liczba} ");
        }
        Console.WriteLine();

        int temp;
        bool posortowane = false;
        int liczbaProb = 0;

        while (!posortowane)
        {
            liczbaProb++;

            for (int r = 1; r <= 3; r++)
            {
                int j = rand.Next(a.Length);
                int k = rand.Next(a.Length);

                temp = a[j];
                a[j] = a[k];
                a[k] = temp;
            }

            posortowane = JestPosortowana(ref a);
        }

        Console.WriteLine("\nTablica po sortowaniu:");
        foreach (int liczba in a)
        {
            Console.Write($"{liczba} ");
        }
        Console.WriteLine();

        Console.WriteLine($"\nLiczba prób: {liczbaProb}");
    }
}