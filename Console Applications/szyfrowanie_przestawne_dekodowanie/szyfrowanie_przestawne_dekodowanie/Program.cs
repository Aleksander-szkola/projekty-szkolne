using System;

class Program
{
    static void Main()
    {
        char[] tekst = { 'l', 'A', ' ', 'a', 'a', 'm', 'k', ' ', 't', 'o', 'a' };
        int n = 11;
        int i = 0;

        while (i < n - 1)
        {
            char z = tekst[i];
            tekst[i] = tekst[i + 1];
            tekst[i + 1] = z;
            i += 2;
        }

        string odszyfrowane = new string(tekst);
        Console.WriteLine(odszyfrowane);
    }
}
