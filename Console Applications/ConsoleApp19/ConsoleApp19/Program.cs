using System;

class Program
{
    static void Main()
    {
        Console.Title = "Suma cyfr liczby";
        Console.Write("Podaj liczbę: ");
        int liczba = int.Parse(Console.ReadLine());
        int suma = 0;

        while (liczba > 0)
        {
            suma = suma + (liczba % 10);
            liczba = liczba / 10;
        }

        Console.WriteLine(suma);
    }
}