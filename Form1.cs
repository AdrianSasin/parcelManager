using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;



namespace managerPaczek
{
    public partial class Form1 : Form
    {
        private List<przesylka> przesylki = new List<przesylka>();

        public Form1()
        {
            InitializeComponent();

            // Szerokoœæ kolumn dopasowana do zawartoœci
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //kolorki
            dataGridView1.RowPrePaint += DataGridView1_RowPrePaint;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();

                if (form2.ShowDialog() == DialogResult.OK && form2.NowaPrzesylka != null)
                {
                    przesylki.Add(form2.NowaPrzesylka);
                    OdswiezWidok();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("B³¹d: " + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nieoczekiwany b³¹d: " + ex.Message, "B³¹d krytyczny", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                przesylki.RemoveAt(index);
                OdswiezWidok();
            }
            else
            {
                MessageBox.Show("Zaznacz wiersz do usuniêcia.");
            }
        }
        public class WidokPrzesylki
        {
            public string Typ { get; set; }
            public string Nadawca { get; set; }
            public string Odbiorca { get; set; }
            public double Waga { get; set; }
            public string Cena { get; set; }
            public string Status { get; set; }
            public string AdresLubSymbol { get; set; }
        }

        private void OdswiezWidok()
        {
            var daneWidoku = new List<WidokPrzesylki>();

            foreach (var p in przesylki)
            {
                if (p is przesylkaKurierska kurier)
                {
                    daneWidoku.Add(new WidokPrzesylki
                    {
                        Typ = "Kurierska",
                        Nadawca = kurier.Nadawca,
                        Odbiorca = kurier.Odbiorca,
                        Waga = kurier.Waga,
                        Cena = kurier.Cena.ToString("0.00"),
                        Status = kurier.Status.ToString(),
                        AdresLubSymbol = kurier.AdresDostawy?.ToString()
                    });
                }
                else if (p is przesylkaPaczkomatowa paczkomat)
                {
                    daneWidoku.Add(new WidokPrzesylki
                    {
                        Typ = "Paczkomatowa",
                        Nadawca = paczkomat.Nadawca,
                        Odbiorca = paczkomat.Odbiorca,
                        Waga = paczkomat.Waga,
                        Cena = paczkomat.Cena.ToString("0.00"),
                        Status = paczkomat.Status.ToString(),
                        AdresLubSymbol = paczkomat.SymbolPaczkomatu
                    });
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = daneWidoku;
            
        }


      

        private void Form1_Load(object sender, EventArgs e)
        {
            
            OdswiezWidok(); // wyœwietl na DataGridView
        }

        private void DataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];

            if (row.DataBoundItem is WidokPrzesylki p)
            {
                // Kolory t³a (typ przesy³ki)
                if (p.Typ == "Kurierska")
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                else if (p.Typ == "Paczkomatowa")
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightSlateGray;

                // Kolory tekstu (status przesy³ki)
                switch (p.Status)
                {
                    case "Oczekujaca":
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                        break;
                    case "WTrakcie":
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Orange;
                        break;
                    case "Dostarczona":
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
                        break;
                    default:
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                        break;
                }
            }
        }
        //zapis do xml
        private void ZapiszDoXml()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<przesylka>));
                using (var writer = new StreamWriter("przesylki.xml"))
                {
                    serializer.Serialize(writer, przesylki);
                }

                MessageBox.Show("Zapisano do pliku XML.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("B³¹d zapisu XML: " + ex.Message);
            }


        }

        //odczyt z xml
        private void WczytajZXml()
        {
            try
            {
                if (File.Exists("przesylki.xml"))
                {
                    var serializer = new XmlSerializer(typeof(List<przesylka>));
                    using (var reader = new StreamReader("przesylki.xml"))
                    {
                        przesylki = (List<przesylka>)serializer.Deserialize(reader);
                    }

                    OdswiezWidok();
                    MessageBox.Show("Wczytano z pliku XML.");
                }
                else
                {
                    MessageBox.Show("Plik XML nie istnieje.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d odczytu XML: " + ex.Message);
            }
        }

        private void btnZapiszXml_Click(object sender, EventArgs e)
        {
            ZapiszDoXml();
        }

        private void btnWczytajXml_Click(object sender, EventArgs e)
        {
            WczytajZXml();
        }

       
    }
}
