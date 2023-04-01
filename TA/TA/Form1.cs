using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA
{
    public partial class Form1 : Form
    {
        private Bitmap original;
        private Bitmap resultante;
        private int[] histograma = new int[256];

        private int anchoVentana, altoVentana;
        public Form1()
        {
            InitializeComponent();

            resultante = new Bitmap(800, 600);

            anchoVentana = 800;
            altoVentana = 600;
        }

        
        //Procesamiento de Imagen
        private void expansionHistogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int minValue = 255;
            int maxValue = 0;
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    int pixelValue = original.GetPixel(i, j).R;
                    if (pixelValue < minValue)
                    {
                        minValue = pixelValue;
                    }
                    if (pixelValue > maxValue)
                    {
                        maxValue = pixelValue;
                    }
                }
            }

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    int pixelValue = original.GetPixel(i, j).R;
                    double expandedValue = ((double)(pixelValue - minValue) / (double)(maxValue - minValue)) * 255.0;
                    resultante.SetPixel(i, j, Color.FromArgb((int)expandedValue, (int)expandedValue, (int)expandedValue));
                }
            }


            this.Invalidate();
        }

        private void ecualizacionHistogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0; int y = 0;
            int cOriginalR = 0;

            int suma = 0;
            int[] sumah = new int[256];

            int tonoR = 0;

            Color miColor;

            double constante = 0;

            for (x = 0; x < 255; x++)
            {
                suma = suma + histograma[x];
                sumah[x] = suma;
            }

            constante = (double)(suma) / (double)(original.Width * original.Height);

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    cOriginalR = original.GetPixel(x, y).R;


                    tonoR = (int)((double)sumah[cOriginalR] * constante);
                    if (tonoR > 255) tonoR = 255;



                    miColor = Color.FromArgb(tonoR, tonoR, tonoR);
                    resultante.SetPixel(x, y, miColor);
                }
            }

            this.Invalidate();
        }

        //Hisograma
        private void histogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0; int y = 0;
            Color rColor = new Color();

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    rColor = resultante.GetPixel(x, y);
                    histograma[rColor.R]++;
                    histograma[rColor.G]++;
                    histograma[rColor.B]++;
                }
            }

            Form2 hfrom = new Form2(histograma);
            hfrom.Show();
        }

        //Filtro de Tono Gris
        private void filtroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0; int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            float g = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    g = oColor.R * 0.299f + oColor.G * 0.587f + oColor.B * 0.114f;

                    rColor = Color.FromArgb((int)g, (int)g, (int)g);

                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        //Control de Archivos
        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                anchoVentana = original.Width;
                altoVentana = original.Height;

                resultante = original;

                this.Invalidate();
            }
        }
        private void guardarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultante.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (resultante != null)
            {
                Graphics g = e.Graphics;
                AutoScrollMinSize = new Size(anchoVentana, altoVentana);
                g.DrawImage(resultante,
                    new Rectangle(this.AutoScrollPosition.X,
                                    this.AutoScrollPosition.Y + 30,
                                        anchoVentana, altoVentana));
                g.Dispose();
            }
        }

    }
}