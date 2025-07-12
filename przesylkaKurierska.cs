using System;

namespace managerPaczek
{
    public class przesylkaKurierska : przesylka
    {
        public Adres AdresDostawy { get; set; }

        // Konstruktor bezparametrowy dla XML
        public przesylkaKurierska() : base("","", 0, 0, StatusPrzesylki.Oczekujaca)
        {
            AdresDostawy = new Adres();
        }

        // Główny konstruktor używany przez aplikację
        public przesylkaKurierska(string nadawca, string odbiorca, double waga, double cena, StatusPrzesylki status, Adres adres)
            : base(nadawca, odbiorca, waga, cena, status)
        {
            AdresDostawy = adres;
        }
    }

    public class Adres
    {
        public string Ulica { get; set; }
        public string NrDomu { get; set; }
        public string NrMieszkania { get; set; }
        public string KodPocztowy { get; set; }
        public string Miejscowosc { get; set; }

        public Adres() { }

        public Adres(string ulica, string nrDomu, string nrMieszkania, string kodPocztowy, string miejscowosc)
        {
            Ulica = ulica;
            NrDomu = nrDomu;
            NrMieszkania = nrMieszkania;
            KodPocztowy = kodPocztowy;
            Miejscowosc = miejscowosc;
        }

        public override string ToString()
        {
            return $"{Ulica} {NrDomu}/{NrMieszkania}, {KodPocztowy} {Miejscowosc}";
        }
    }
}
