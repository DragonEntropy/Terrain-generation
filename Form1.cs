using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Terrain
{
    public partial class Form1 : Form
    {
        static Graphics g;
        string[] colours = {"#ff0000", "#ff7f50", "#ffa500", "#ffd700", "#00ff00", "#00ff7f", "#20b2aa", "#00ffff", "#00ced1", "#0000ff", "#8a2be2", "#660066", "#333333"};
        int colourCount = 13;
        Thread backgroundThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //runGenerator();
            if (backgroundThread != null)
            {
                backgroundThread.Abort();
            }
            backgroundThread = new Thread(runGenerator);
            backgroundThread.Start();
        }

        void runGenerator()
        {
            Random rand = new Random();
            int rows = mainPanel.Height;
            int cols = mainPanel.Width;

            g = mainPanel.CreateGraphics();
            double gen = Convert.ToDouble(genBox.Text);
            double amp = Convert.ToDouble(amplitudeBox.Text);
            double blt = Convert.ToDouble(bloatBox.Text);
            double spn = Convert.ToDouble(spanBox.Text);

            double[,] terrain = new double[rows, cols];
            TerrainGenerator[,] generators = new TerrainGenerator[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    generators[row, col] = new TerrainGenerator(col, row, rand, gen, amp, blt, spn);
                    generators[row, col].alterTerrain(terrain, rows, cols);
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    paintPixel(row, col, terrain[row, col]);
                }
            }
        }

        void paintPixel(int yPos, int xPos, double value)
        {
            int index = (int)(value * 6);
            if (index >= colourCount)
            {
                index = colourCount - 1;
            }
            string colour = colours[index];
            
            g.FillRectangle(new SolidBrush(ColorTranslator.FromHtml(colour)), xPos, yPos, 1, 1);
        }
    }

    class TerrainGenerator
    {
        double generatorChance = 0.1;
        double logBase = 2;
        double maxAmplitude = 2;
        double maxBloat = 1;

        int xPos;
        int yPos;
        bool isActive = false;
        double amplitude = 0;
        double bloat = 0;
        int span = 0;

        public TerrainGenerator(int x, int y, Random rand, double gen, double amp, double blt, double spn)
        {
            xPos = x;
            yPos = y;
            generatorChance = gen;
            maxAmplitude = amp;
            maxBloat = blt;
            logBase = spn;

            if (rand.NextDouble() < generatorChance)
            {
                isActive = true;
                amplitude = maxAmplitude * rand.NextDouble();
                bloat = maxBloat * rand.NextDouble();
                span = calculateSpan(rand);
            }
        }

        private int calculateSpan(Random rand)
        {
            return (int)Math.Log(rand.Next(100), logBase);
        }

        private double TerrainEquation(int x, int y, double a, double b)
        {
            return a / (b * x * x + b * y * y + 1);
        }

        public void alterTerrain(double[,] terrain, int rows, int cols)
        {
            if (isActive)
            {
                for (int y = -span; y <= span; y++)
                {
                    if (yPos + y >= 0 && yPos + y < rows)
                    {
                        for (int x = -span; x <= span; x++)
                        {
                            if (xPos + x >= 0 && xPos + x < cols)
                            {
                                terrain[yPos + y, xPos + x] += TerrainEquation(x, y, amplitude, bloat);
                                Console.WriteLine("Value at {0}, {1} is {2}", yPos + y, xPos + x, terrain[yPos + y, xPos + x]);
                            }
                        }
                    }
                }
            }
        }
    }
}
