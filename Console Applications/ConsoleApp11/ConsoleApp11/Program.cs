using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Sorawdzanie czy liczba należy do zbioru";
        int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Podaj liczbe: ");
        int x = int.Parse(Console.ReadLine());
        bool nalezy = false;

        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i] == x)
            {
                nalezy = true;
                break;
            }
        }

        if (nalezy)
        {
            Console.WriteLine("Liczba nalezy do zbioru.");
        }
        else
        {
            Console.WriteLine("Liczba nie nalezy do zbioru.");
        }
    }
}
