using System;
class Program
{
    static void Main()
    {
        Console.Write("Podaj ciąg znaków: ");
        string input = Console.ReadLine();

        string reversed = "";
        for (int i = input.Length - 1; i >=0; i--)
        {
            reversed += input[i];
        }

        Console.Write($"Odwrócony ciąg znaków to: {reversed}");
    }
}