using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab02_WeatherApi
{
    public partial class WeatherApiForm : Form
    {

        private DBManager db;
        int kryteriumSortowania = 0;
        int jakiWykres = 0;
        public WeatherApiForm()
        {
            InitializeComponent();

            db = new DBManager();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // do nothing
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //  do nothing
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double latitude;
            bool czyNieMaBleduLatitude = double.TryParse(textBox1.Text, out latitude);

            if (!czyNieMaBleduLatitude)
            {
                MessageBox.Show("Nieprawidlowy format wspolrzednych");
                textBox1.Focus(); // Ustaw fokus na textBox
                textBox1.SelectAll(); // Zaznacz caly tekst w textBox1, zeby szybko wprowadzic nowe dane
            }
            double longitude;
            bool czyNieMaBleduLongitude = double.TryParse(textBox2.Text, out longitude);

            if (!czyNieMaBleduLongitude)
            {
                MessageBox.Show("Nieprawidlowy format wspolrzednych");
                textBox1.Focus();
                textBox1.SelectAll();
            }
            if (czyNieMaBleduLatitude == true && czyNieMaBleduLongitude == true)
            {
                db.Dodaj(latitude, longitude);
            }
            else
            {
                MessageBox.Show("Nieprawidlowy format wspolrzednych");
            }
        }

        private void WypiszDane(List<Struktura> Lista)
        {
            var dbList = Lista;
            listBox1.Items.Clear();
            foreach (var item in dbList)
            {
                listBox1.Items.Add($"Id: {item.Id}");
                listBox1.Items.Add($"Miasto: {item.city_name}");
                listBox1.Items.Add($"Temperatura: {item.temp.ToString("0.0")} °C");
                listBox1.Items.Add($"Wiatr: {item.speed} m/s");
                listBox1.Items.Add($"Wilgotnosc: {item.humidity} %");
                listBox1.Items.Add($"Cisnienie: {item.pressure} hPa");
                listBox1.Items.Add($"Temp. odczuwalna: {item.feels_like.ToString("0.0")} °C");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dbList = db.Lista();

            WypiszDane(dbList);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string wybraneMiatsoText = textBox3.Text;
            var dbList = db.Lista();
            int dlugoscListy = 0;

            listBox1.Items.Clear();
            foreach (var item in dbList)
            {
                if (item.city_name == wybraneMiatsoText)
                {
                    listBox1.Items.Add($"Id: {item.Id}");
                    listBox1.Items.Add($"Miasto: {item.city_name}");
                    listBox1.Items.Add($"Temperatura: {item.temp.ToString("0.0")} °C");
                    listBox1.Items.Add($"Wiatr: {item.speed} m/s");
                    listBox1.Items.Add($"Wilgotnosc: {item.humidity} %");
                    listBox1.Items.Add($"Cisnienie: {item.pressure} hPa");
                    listBox1.Items.Add($"Temp. odczuwalna: {item.feels_like.ToString("0.0")} °C");
                    dlugoscListy++;
                }
            }
            if (dlugoscListy == 0)
            {
                MessageBox.Show("Dane misto nie wystepuje w bazie danych, podaj wspolrzedne i wprowadz je do bazy");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // temp odczuwalna
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                kryteriumSortowania = 1;
            }
            else
            {
                kryteriumSortowania = 0;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) // wilgotnosc
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                kryteriumSortowania = 2;
            }
            else
            {
                kryteriumSortowania = 0;
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) // temp zmierzona
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                kryteriumSortowania = 3;
            }
            else
            {
                kryteriumSortowania = 0;
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dbList = db.Lista();

            switch (kryteriumSortowania)
            {
                case 1:
                    dbList.Sort((x, y) => y.feels_like.CompareTo(x.feels_like));
                    WypiszDane(dbList);
                    break;
                case 2:
                    dbList.Sort((x, y) => y.humidity.CompareTo(x.humidity));
                    WypiszDane(dbList);
                    break;
                case 3:
                    dbList.Sort((x, y) => y.temp.CompareTo(x.temp));
                    WypiszDane(dbList);
                    break;
                default:
                    MessageBox.Show("Nie wybrano zadnego kryterium sortowania.");
                    break;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) // temp zmierzona
            {
                checkBox5.Enabled = false;
                jakiWykres = 1;
            }
            else
            {
                checkBox5.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) // temp zmierzona
            {
                checkBox4.Enabled = false;
                jakiWykres = 2;
            }
            else
            {
                checkBox4.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var dbList = db.Lista();
            switch (jakiWykres)
            {
                case 1:
                    WyswietlWykres(dbList);
                    break;
                case 2:
                    WyswietlWykres(dbList);
                    break;
                default:
                    MessageBox.Show("Nie wybrano zadnego kryterium do utworzenia wykresu.");
                    break;
            }
        }

        private void WyswietlWykres(List<Struktura> lista)
        {
            // nowy wykres i jego rozmiar
            Chart wykres = new Chart();
            wykres.Size = new Size(600, 400);

            wykres.ChartAreas.Add(new ChartArea());
            wykres.Series.Add(new Series("Temp"));
            wykres.Series["Temp"].ChartType = SeriesChartType.Column;

            if (jakiWykres == 1)
            {
                foreach (var item in lista)
                {
                    wykres.Series["Temp"].Points.AddXY(item.city_name, item.temp);
                }
            }
            else if (jakiWykres == 2)
            {
                foreach (var item in lista)
                {
                    wykres.Series["Temp"].Points.AddXY(item.city_name, item.humidity);
                }
            }

            // Utwórz nowe okno
            Form wykresForm = new Form();
            wykresForm.Text = "Wykres Pogodowy";
            wykresForm.Size = new Size(700, 500);
            wykresForm.Controls.Add(wykres);

            // Wyœwietl nowe okno
            wykresForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            db.usun();
        }
    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Clouds
    {
        public int all { get; set; }
    }

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    }

    public class Root
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }
}
