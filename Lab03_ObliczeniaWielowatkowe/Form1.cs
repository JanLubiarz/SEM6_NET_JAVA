using System.Threading;

namespace Lab03_ObliczeniaWielowatkowe
{
    public partial class Form1 : Form
    {
        Matrix mx1;
        Matrix mx2;
        Matrix resultMatrix;
        LL lowThreadMethod;
        HL highThreadMethod;
        int seed1;
        int seed2;
        int dimension;
        int numOfThreads;
        long elapsedTimeLL;
        long elapsedTimeHL;

        public Form1()
        {
            InitializeComponent();
            mx1 = new Matrix();
            mx2 = new Matrix();
            resultMatrix = new Matrix();
            lowThreadMethod = new LL();
            highThreadMethod = new HL();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool dimensionParsed = int.TryParse(textBox2.Text, out dimension);

            if (!dimensionParsed)
            {
                MessageBox.Show("Nieprawidlowy format danych, podaj liczbe calkowita");
                textBox2.Focus();
                textBox2.SelectAll();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool numOfThreadsParsed = int.TryParse(textBox1.Text, out numOfThreads);

            if (!numOfThreadsParsed)
            {
                MessageBox.Show("Nieprawidlowy format danych, podaj liczbe calkowita");
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //resultMatrix = highThreadMethod.MultiplyWithLimitation(mx1, mx2, numOfThreads);
            resultMatrix = highThreadMethod.MultiplyWithoutLimitation(mx1, mx2);
            watch.Stop();
            elapsedTimeLL = watch.ElapsedMilliseconds;
            Console.WriteLine($"Threads ended in {watch.ElapsedMilliseconds} ms.");
            textBox6.Text = elapsedTimeLL.ToString();
            //textBox8.Text = resultMatrix.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            resultMatrix = lowThreadMethod.CreateThreads(mx1, mx2, numOfThreads);
            watch.Stop();
            elapsedTimeLL = watch.ElapsedMilliseconds;
            Console.WriteLine($"Threads ended in {watch.ElapsedMilliseconds} ms.");
            textBox6.Text = elapsedTimeLL.ToString();
            //textBox8.Text = resultMatrix.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mx1.createMatrix(dimension, seed1);
            mx2.createMatrix(dimension, seed2);
            //textBox3.Text = mx1.ToString();
            //textBox7.Text = mx2.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            bool seedParsed1 = int.TryParse(textBox4.Text, out seed1);

            if (!seedParsed1)
            {
                MessageBox.Show("Nieprawidlowy format danych, podaj liczbe calkowita");
                textBox4.Focus();
                textBox4.SelectAll();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            bool seedParsed2 = int.TryParse(textBox9.Text, out seed2);

            if (!seedParsed2)
            {
                MessageBox.Show("Nieprawidlowy format danych, podaj liczbe calkowita");
                textBox9.Focus();
                textBox9.SelectAll();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            resultMatrix = lowThreadMethod.Multiply(mx1, mx2);
            watch.Stop();
            elapsedTimeLL = watch.ElapsedMilliseconds;
            Console.WriteLine($"Threads ended in {watch.ElapsedMilliseconds} ms.");
            textBox6.Text = elapsedTimeLL.ToString();
            //textBox8.Text = resultMatrix.ToString();
        }
    }
}
