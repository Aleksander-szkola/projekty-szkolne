using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] tablica = { 4, 2, 2, 8, 3, 3, 3, 1 };
            int max = tablica[0];

            foreach (int i in tablica)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            Console.WriteLine($"Największa liczba to {max}");
        }
    }
}