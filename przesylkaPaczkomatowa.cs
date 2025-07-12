namespace managerPaczek
{
    public class przesylkaPaczkomatowa : przesylka
    {
        public string SymbolPaczkomatu { get; set; } // np. POZ12

        // Wymagany do deserializacji XML
        public przesylkaPaczkomatowa() : base("","", 0, 0, StatusPrzesylki.Oczekujaca) { }

        public przesylkaPaczkomatowa(string nadawca, string odbiorca, double waga, double cena, StatusPrzesylki status, string symbolPaczkomatu)
            : base(nadawca, odbiorca, waga, cena, status)
        {
            SymbolPaczkomatu = symbolPaczkomatu;
        }
    }
}
