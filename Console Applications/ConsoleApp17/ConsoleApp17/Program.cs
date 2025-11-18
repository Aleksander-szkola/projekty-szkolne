using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Zamiana arabskich na rzymskie";

        string[] Rzymskie = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] Arabskie = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        
        Console.Write("Podaj liczbę całkowitą (1-3999): ");
        int liczba = int.Parse(Console.ReadLine());
        
        if (liczba < 1 || liczba > 3999)
        {
            Console.WriteLine("Błąd, liczba jest poza zakresem!");
            return;
        }
        
        string wynik = "";
        int N = Arabskie.Length;
        
        for (int i = 0; i < N; i++)
        {
            while (Arabskie[i] <= liczba)
            {
                wynik += Rzymskie[i];
                liczba -= Arabskie[i];
            }
        }
        
        Console.WriteLine($"Rzymskie: {wynik}");
    }
}