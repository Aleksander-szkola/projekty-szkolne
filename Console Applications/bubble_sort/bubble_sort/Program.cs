using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] tablica = { 2, 5, 7, 1, 12, 8 };

            Console.Write("Tablica przed sortowaniem: ");
            foreach (int i in tablica)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            int n = tablica.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
            }
            Console.Write("Tablica posortowana: ");
            foreach (int i in tablica)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}