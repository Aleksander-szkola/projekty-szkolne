using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Obliczanie objętości beczki";
         Console.Write("Podaj wysokość beczki: ");
        double h = double.Parse(Console.ReadLine());
        
        Console.Write("Podaj promień w najszerszym punkcie: ");
        double R = double.Parse(Console.ReadLine());
        
        Console.Write("Podaj promień w najwęższym punkcie: ");
        double r = double.Parse(Console.ReadLine());
        
        if (h > 0 && R > 0 && r > 0 && R > r)
        {
            double V = (Math.PI * h / 15) * ((8 * (R * R)) + (4 * r * R) + (3 * (r * r)));
            Console.WriteLine("Objętość beczki wynosi: " + V);
        }
        else
        {
            Console.WriteLine("Błąd, wartości się nie zgadzają. Wszystkie wartości powinny być większe od 0, a promień w najszerszym punkcie powinien być większy od najwęższego.");
        }
    }
}
