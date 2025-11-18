using System;

class Program
{
    static string encrypt(string text, int shift)
    {
        char[] buffer = text.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                char baseChar = char.IsUpper(letter) ? 'A' : 'a';
                buffer[i] = (char)(baseChar + (letter - baseChar + shift) % 26);
            }
        }
        return new string(buffer);
    }

    static string decrypt(string text, int shift)
    {
        char[] buffer = text.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                char baseChar = char.IsUpper(letter) ? 'A' : 'a';
                buffer[i] = (char)(baseChar + (letter - baseChar - shift + 26) % 26); // +26 to handle negative results
            }
        }
        return new string(buffer);
    }

    static void Main()
    {
        string choice = "";
        while (true)
        {
            Console.WriteLine("Szyfrowanie czy deszyfrowanie? (S/D):");
            choice = Console.ReadLine().ToUpper();

            if (choice == "S" || choice == "D")
                break;

            Console.WriteLine("Wprowadź 'S' dla szyfrowania lub 'D' dla deszyfrowania.");
        }

        Console.Write("Podaj tekst: ");
        string text = Console.ReadLine();

        int shift = 0;
        while (true)
        {
            Console.Write("O ile przesunąć?: ");
            if (int.TryParse(Console.ReadLine(), out shift))
            {
                break;
            }
            else
            {
                Console.WriteLine("Proszę podać liczbę całkowitą.");
            }
        }

        if (choice == "S")
        {
            string encryptedText = encrypt(text, shift);
            Console.WriteLine($"Zaszyfrowany tekst to: {encryptedText}");
        }
        else if (choice == "D")
        {
            string decryptedText = decrypt(text, shift);
            Console.WriteLine($"Rozszyfrowany tekst to: {decryptedText}");
        }
    }
}
