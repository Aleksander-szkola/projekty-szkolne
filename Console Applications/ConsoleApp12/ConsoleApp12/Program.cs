using System;

class Program
{
    static void Main()
    {

        Console.Title = "Rozwiązywanie równania kwadratowego";
        Console.Write("Podaj a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Podaj b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Podaj c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("To nie jest rownanie kwadratowe");
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Brak rozwiazan");
            }
            else if (delta == 0)
            {
                double x0 = -b / (2 * a);
                Console.WriteLine("x0 = " + x0);
            }
            else
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = " + x1 + ", x2 = " + x2);
            }
        }
    }
}
