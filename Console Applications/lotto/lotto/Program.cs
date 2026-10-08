using System;

class Lotto
{
    private int[] liczby = new int[6];
    private Random random = new Random();

    public void Losuj()
    {
        for (int i = 0; i < liczby.Length; i++)
        {
            bool powtorzenie = true;
            int liczba = 0;

            while (powtorzenie)
            {
                liczba = random.Next(1, 50);
                powtorzenie = false;

                for (int j = 0; j < i; j++)
                {
                    if (liczby[j] == liczba)
                    {
                        powtorzenie = true;
                    }
                }
            }
            liczby[i] = liczba;
        }
    }
    public void Wyswietl()
    {
        for (int i = 0; i <= liczby.Length - 1; i++)
        {
            Console.Write(liczby[i] + " ");
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Ile losowań: ");
        int ile = int.Parse(Console.ReadLine());

        for (int i = 0; i < ile; i++)
        {
            Lotto lotto = new Lotto();

            lotto.Losuj();
            lotto.Wyswietl();
        }
    }
}