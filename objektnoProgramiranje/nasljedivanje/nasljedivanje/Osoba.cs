using System;

public class Osoba
{

    private string m_ime;
    private string m_prezime;


    public string ime
    {
        get { return m_ime; }
        set { m_ime = value; }
    }

    public string prezime
    {
        get { return m_prezime; }
        set { m_prezime = value; }
    }


    public void ispis()
    {
        Console.WriteLine("Ime: {0}\nPrezime: {1}", m_ime, m_prezime);
    }
}