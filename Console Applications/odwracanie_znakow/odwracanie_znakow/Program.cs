using System;
class Program
{
    static void Main()
    {
        Console.Write("Podaj ciąg znaków: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        Console.Write($"Odwrócony ciąg znaków to: {reversed}");
    }
}