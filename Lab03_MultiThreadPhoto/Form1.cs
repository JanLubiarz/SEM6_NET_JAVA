using System.Windows.Forms;

namespace Lab03_MultiThreadPhoto
{
    public partial class Form1 : Form
    {
        public static readonly object locker = new object();
        private Bitmap? img;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\Jan £ubiarz\\OneDrive\\Pobrane_assety\\Pulpit\\SEM6\\net java\\sprawozdanie3";

            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                img = new Bitmap(file);
                img = new Bitmap(img, new Size(374, 274));

                pictureBox1.Size = new Size(374, 274);
                pictureBox1.Image = img;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap? grayscaleImage = null;
            Bitmap? invertedImage = null;
            Bitmap? mirrorImage = null;
            Bitmap? thresholdingImage = null;

            Parallel.Invoke(
                () => grayscaleImage = GrayscaleFilter(img),
                () => invertedImage = InvertColorsFilter(img),
                () => thresholdingImage = ThresholdingFilter(img),
                () => mirrorImage = MirrorImage(img)
            );

            pictureBox2.Size = new Size(188, 136);
            pictureBox2.Image = invertedImage;

            pictureBox3.Size = new Size(188, 136);
            pictureBox3.Image = grayscaleImage;

            pictureBox4.Size = new Size(188, 136);
            pictureBox4.Image = thresholdingImage;

            pictureBox5.Size = new Size(188, 136);
            pictureBox5.Image = mirrorImage;
        }

        private Bitmap? ThresholdingFilter(Bitmap? originalImage)
        {
            Bitmap? thresholdingImage;
            lock (locker)
            {
                thresholdingImage = new Bitmap(originalImage.Width, originalImage.Height);
            }

            // Najpierw zamienie na odcienie szarosci aby ustalic latwo prog dla jednego koloru a nie osobno dla skladowych RGB
            for (int y = 0; y < thresholdingImage.Height; y++)
            {
                for (int x = 0; x < thresholdingImage.Width; x++)
                {
                    Color originalColor;
                    lock (locker)
                    {
                        originalColor = originalImage.GetPixel(x, y);
                    }

                    int threshold = 125;
                    int grayValue = (originalColor.R + originalColor.G + originalColor.B) / 3;

                    if (grayValue <= threshold) thresholdingImage.SetPixel(x, y, Color.Black);
                    else thresholdingImage.SetPixel(x, y, Color.White);

                }
            }

            thresholdingImage = new Bitmap(thresholdingImage, new Size(188, 136));
            return thresholdingImage;
        }

        private Bitmap? MirrorImage(Bitmap originalImage)
        {
            Bitmap? mirrorImage;
            lock (locker)
            {
                mirrorImage = new Bitmap(originalImage.Width, originalImage.Height);
            }

            for (int y = 0; y < mirrorImage.Height; y++)
            {
                for (int x = 0; x < mirrorImage.Width; x++)
                {
                    lock (locker)
                    {
                        mirrorImage.SetPixel((mirrorImage.Width-(1+x)), y, originalImage.GetPixel(x, y));
                    }
                }
            }
            mirrorImage = new Bitmap(mirrorImage, new Size(188, 136));
            return mirrorImage;
        }

        private Bitmap? InvertColorsFilter(Bitmap originalImage)
        {
            Bitmap? invertColorsImage;
            lock (locker)
            {
                invertColorsImage = new Bitmap(originalImage.Width, originalImage.Height);
            }

            for (int y = 0; y < invertColorsImage.Height; y++) 
            {
                for (int x = 0; x < invertColorsImage.Width; x++)
                {
                    Color originalColor;
                    lock (locker)
                    {
                        originalColor = originalImage.GetPixel(x, y);
                    }

                    int invertColorR = Math.Abs(originalColor.R - 255);
                    int invertColorG = Math.Abs(originalColor.G - 255);
                    int invertColorB = Math.Abs(originalColor.B - 255);

                    Color invertColor = Color.FromArgb(invertColorR, invertColorG, invertColorB);

                    invertColorsImage.SetPixel(x, y, invertColor);

                }
            }

            invertColorsImage = new Bitmap(invertColorsImage, new Size(188, 136));
            return invertColorsImage;
        }

        private Bitmap? GrayscaleFilter(Bitmap originalImage)
        {

            Bitmap? grayscaleImage;
            lock (locker)
            {
                grayscaleImage = new Bitmap(originalImage.Width, originalImage.Height);
            }
            // Przetwarzam kazdy piksel mojego obrazu
            for (int y = 0; y < grayscaleImage.Height; y++)
            {
                for (int x = 0; x < grayscaleImage.Width; x++)
                {
                    Color originalColor;
                    lock (locker)
                    {
                        originalColor = originalImage.GetPixel(x, y);
                    }
                    int grayValue = (originalColor.R + originalColor.G + originalColor.B) / 3;

                    // Tworze nowy kolor o barwie odcieni szarosci
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);

                    // Ustawiam nowy kolor na obrazie
                    grayscaleImage.SetPixel(x, y, grayColor);
                }
            }

            // Po przetworzeniu kazdego piksela obrazu zmniejszamy jego wielkosc
            grayscaleImage = new Bitmap(grayscaleImage, new Size(188, 136));
            return grayscaleImage;        
        }
    }
}
