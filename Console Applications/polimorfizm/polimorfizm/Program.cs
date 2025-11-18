using System;

public class Ksztalt
{
    public string Kolor { get; set; }

    public virtual double ObliczPole()
    {
        Console.Write("Nie określono sposobu obliczania pola dla tego kształtu\n");
        return 0;
    }
    public void Opis()
    {
        Console.Write($"To jest kształt w kolorze: {Kolor}\n");
    }
}
public class Kolo : Ksztalt
{
    public double Promien { get; set; }
    public Kolo(double promien)
    {
        Promien = promien;
        Kolor = "czerwony";
    }
    public override double ObliczPole() => Math.PI * Promien * Promien;
}
public class Prostokat : Ksztalt
{
    public double BokA { get; set; }
    public double BokB { get; set; }
    public Prostokat(double a, double b)
    {
        BokA = a;
        BokB = b;
        Kolor = "niebieski";
    }
    public override double ObliczPole() => BokA * BokB;
}
class Program
{
    static void Main()
    {
        Ksztalt ksztalt = new Ksztalt();
        Kolo kolo = new Kolo(3);
        Prostokat prostokat = new Prostokat(4, 5);

        ksztalt.Opis();
        Console.Write($"Pole: {ksztalt.ObliczPole()}\n\n");
        kolo.Opis();
        Console.Write($"Pole: {kolo.ObliczPole()}\n\n");
        prostokat.Opis();
        Console.Write($"Pole: {prostokat.ObliczPole()}\n\n");
    }
}