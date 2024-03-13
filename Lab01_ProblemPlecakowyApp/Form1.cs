using Lab01;

namespace Lab01_ProblemPlecakowyApp
{
    public partial class Form1 : Form
    {
        int iloscPrzedmiotow;
        int ziarno;
        int pojemnosc;
        bool czyNieMaBledowZiarno = false;
        bool czyNieMaBledowPojemnosc = false;
        bool czyNieMaBledowLiczbaPrzedmiotow = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string iloscPrzedmiotowText = textBox1.Text;
            int parsedIloscPrzedmiotow;

            if (int.TryParse(iloscPrzedmiotowText, out parsedIloscPrzedmiotow))
            {
                // ciag jest w prawidlowym formacie, przypisujemy wartosc
                iloscPrzedmiotow = parsedIloscPrzedmiotow;
                czyNieMaBledowLiczbaPrzedmiotow = true;
            }
            else
            {
                // obsluga bledu
                MessageBox.Show("Nieprawid³owy format liczby ca³kowitej.");
                czyNieMaBledowLiczbaPrzedmiotow = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (czyNieMaBledowZiarno && czyNieMaBledowPojemnosc && czyNieMaBledowLiczbaPrzedmiotow)
            {
                ProblemPlecakowy problemPlecakowy = new ProblemPlecakowy(iloscPrzedmiotow, ziarno);
                textBox4.Text = problemPlecakowy.ToString();
                Result wynik = problemPlecakowy.Solve(pojemnosc);
                textBox5.Text = wynik.ToString();
            }
            else
            {
                // obsluga bledu
                MessageBox.Show("Popraw dane wejsciowe, najprawdopodobniej nie podano tam liczby calkowitej.");
            }

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            string pojemnoscText = textBox3.Text;
            int parsedPojemnosc;

            if (int.TryParse(pojemnoscText, out parsedPojemnosc))
            {
                // ciag jest w prawidlowym formacie, przypisujemy wartosc
                pojemnosc = parsedPojemnosc;
                czyNieMaBledowPojemnosc = true;
            }
            else
            {
                // obsluga bledu
                MessageBox.Show("Nieprawid³owy format liczby ca³kowitej.");
                czyNieMaBledowPojemnosc = false;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string ziarnoText = textBox2.Text;
            int parsedZiarno;

            if (int.TryParse(ziarnoText, out parsedZiarno))
            {
                // ciag jest w prawidlowym formacie, przypisujemy wartosc
                ziarno = parsedZiarno;
                czyNieMaBledowZiarno = true;
            }
            else
            {
                // obsluga bledu
                MessageBox.Show("Nieprawid³owy format liczby ca³kowitej.");
                czyNieMaBledowZiarno = false;
            }
        }
    }
}

