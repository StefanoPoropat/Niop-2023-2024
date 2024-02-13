using static Nasljedjivanje.Program;
using System;

public class Ucenik : Osoba
{

    public Ucenik() { }
    private string m_razred;

    public string razred
    {
        get { return m_razred; }
        set { m_razred = value; }
    }
    public new void ispis()
    {
        Console.WriteLine("Ime: {0}\nPrezime: {1}\nRazred: {2}", ime, prezime, m_razred);
    }

}