using managerPaczek;
using System.Xml.Serialization;

[XmlInclude(typeof(przesylkaKurierska))]
[XmlInclude(typeof(przesylkaPaczkomatowa))]
public abstract class przesylka
{
    public string Nadawca { get; set; }
    public string Odbiorca { get; set; }
    public double Waga { get; set; }
    public double Cena { get; set; }

    public enum StatusPrzesylki
    {
        Oczekujaca,
        WTrakcie,
        Dostarczona
    }

    public StatusPrzesylki Status { get; set; }

    protected przesylka(string nadawca,string odbiorca, double waga, double cena, StatusPrzesylki status)
    {
        Nadawca = nadawca;
        Odbiorca = odbiorca;
        Waga = waga;
        Cena = cena;
        Status = status;
    }
}
