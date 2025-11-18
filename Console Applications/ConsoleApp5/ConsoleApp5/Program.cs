using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Kapitalizacja odsetek";
        Console.Write("Podaj kapitał początkowy: ");
        double K = double.Parse(Console.ReadLine());

        Console.Write("Podaj roczną stopę procentową: ");
        double p = double.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę lat: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę kapitalizacji w roku: ");
        int k = int.Parse(Console.ReadLine());

        double Kn = K * Math.Pow(1 + (p / 100 / k), n * k);

        Console.WriteLine("Kapitał końcowy wynosi: " + Math.Round(Kn,2) + "PLN");
    }
}