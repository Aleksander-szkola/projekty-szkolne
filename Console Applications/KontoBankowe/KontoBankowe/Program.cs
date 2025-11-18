using System;
public class Transakcja
{
    public DateTime Data { get; }
    public decimal Kwota { get; }
    public string Opis { get; }
    public Transakcja(decimal kwota, string opis)
    {
        Data = DateTime.Now;
        Kwota = kwota;
        Opis = opis;
    }
}

public class KontoBankowe
{
    private decimal saldo;
    private List<Transakcja> historiaTransakcji = new List<Transakcja>();
    public KontoBankowe(decimal saldoPoczatkowe)
    {
        saldo = saldoPoczatkowe;
    }
    public void Wplac(decimal kwota, string opis)
    {
        if (kwota > 0)
        {
            saldo += kwota;
            historiaTransakcji.Add(new Transakcja(kwota, opis));
        }
    }
    public bool Wyplac(decimal kwota)
    {
        if (kwota > 0 && kwota <= saldo)
        {
            saldo -= kwota;
            return true;
        }
        return false;
    }
    public decimal PodajSaldo()
    {
        return saldo;
    }
    public void WyswietlHistorie()
    {
        Console.Write("Historia transakcji:\n");
        foreach (var w in historiaTransakcji)
        {
            Console.Write($"Kwota: {w.Kwota}, Opis: {w.Opis}, Data: {w.Data}\n");
        }
    }
}

class Program
{
    static void Main()
    {
        KontoBankowe konto = new KontoBankowe(100);
        konto.Wplac(50, "Wynagrodzenie");
        konto.Wyplac(50); //kebab ze znajomym
        konto.Wplac(25, "za kebsa"); //znajomy zwraca pieniądze za kebaba
        konto.WyswietlHistorie();
        Console.Write($"Aktualne saldo: {konto.PodajSaldo()}zł");
    }
}