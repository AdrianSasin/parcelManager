using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managerPaczek
{
    public partial class Form2 : Form
    {
        public przesylka NowaPrzesylka { get; private set; }
        public Form2()
        {
            InitializeComponent();

            cmbTyp.Items.AddRange(new string[] { "Kurierska", "Paczkomatowa" });
            cmbTyp.SelectedIndex = 0;

            cmbStatus.DataSource = Enum.GetValues(typeof(przesylka.StatusPrzesylki));

            cmbTyp.SelectedIndexChanged += cmbTyp_SelectedIndexChanged;
            txtCena.Leave += txtCena_Leave;

            UkryjLubPokazPola();
        }
        private void cmbTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            UkryjLubPokazPola();
        }
        private void UkryjLubPokazPola()
        {
            bool paczkomat = cmbTyp.SelectedItem.ToString() == "Paczkomatowa";

            // Paczkomat
            txtSymbolPaczkomatu.Visible = paczkomat;
            txtSymbolPaczkomatu.Enabled = paczkomat;
            label5.Visible = paczkomat;


            // Adres
            txtUlica.Visible = !paczkomat;
            txtNrDomu.Visible = !paczkomat;
            txtNrMieszkania.Visible = !paczkomat;
            txtKodPocztowy.Visible = !paczkomat;
            txtMiejscowosc.Visible = !paczkomat;
            label6.Visible = !paczkomat; // Ulica
            label7.Visible = !paczkomat; // Nr domu
            label8.Visible = !paczkomat; // Nr mieszkania
            label9.Visible = !paczkomat; // Kod pocztowy
            label10.Visible = !paczkomat; // Miejscowość



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nadawca = txtNadawca.Text.Trim();
            string odbiorca = txtOdbiorca.Text.Trim();
            string cenaStr = txtCena.Text.Trim();
            string wagaStr = txtWaga.Text.Trim();
            var status = (przesylka.StatusPrzesylki)cmbStatus.SelectedItem;

            // Walidacja wspólna
            if (string.IsNullOrWhiteSpace(odbiorca))
            {
                MessageBox.Show("Podaj odbiorcę.");
                return;
            }

            if (!double.TryParse(wagaStr, out double waga) || waga <= 0)
            {
                MessageBox.Show("Waga musi być liczbą dodatnią.");
                return;
            }

            if (!decimal.TryParse(cenaStr, out decimal cenaDecimal) || cenaDecimal <= 0)
            {
                MessageBox.Show("Cena musi być liczbą dodatnią.");
                return;
            }

            if (decimal.Round(cenaDecimal, 2) != cenaDecimal)
            {
                MessageBox.Show("Cena musi mieć dokładnie 2 miejsca po przecinku.");
                return;
            }

            double cena = (double)cenaDecimal;

            try
            {
                if (cmbTyp.SelectedItem.ToString() == "Kurierska")
                {
                    Adres adres = new Adres
                    {
                        Ulica = txtUlica.Text.Trim(),
                        NrDomu = txtNrDomu.Text.Trim(),
                        NrMieszkania = txtNrMieszkania.Text.Trim(),
                        KodPocztowy = txtKodPocztowy.Text.Trim(),
                        Miejscowosc = txtMiejscowosc.Text.Trim()
                    };

                    if (string.IsNullOrWhiteSpace(adres.Ulica) ||
                        string.IsNullOrWhiteSpace(adres.NrDomu) ||
                        string.IsNullOrWhiteSpace(adres.KodPocztowy) ||
                        string.IsNullOrWhiteSpace(adres.Miejscowosc))
                    {
                        MessageBox.Show("Wypełnij pełny adres dostawy.");
                        return;
                    }

                    NowaPrzesylka = new przesylkaKurierska(nadawca, odbiorca, waga, cena, status, adres);
                }
                else // Paczkomatowa
                {
                    string symbol = txtSymbolPaczkomatu.Text.Trim().ToUpper();

                    if (!Regex.IsMatch(symbol, @"^[A-Z]{3}[0-9]{2}$"))
                    {
                        MessageBox.Show("Symbol paczkomatu musi składać się z 3 wielkich liter i 2 cyfr, np. POZ12.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    NowaPrzesylka = new przesylkaPaczkomatowa(nadawca, odbiorca, waga, cena, status, symbol);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtCena_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCena.Text.Trim(), out decimal wartosc) && wartosc > 0)
            {
                txtCena.Text = wartosc.ToString("0.00");
            }
        }

        
    }
}
