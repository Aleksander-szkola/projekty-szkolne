using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Obliczanie objętości kuli";
        Console.Write("Podaj promień kuli: ");
        double r = double.Parse(Console.ReadLine());

        if (r > 0)
        {

            double V = (4.0 / 3.0) * Math.PI * (r * r * r);
            Console.WriteLine("Objętość kuli wynosi: " + V);
        }
        else
        {
            Console.WriteLine("Promień musi być większy od 0");
        }
    }
}
