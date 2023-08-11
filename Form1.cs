using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace MyGameLife
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private bool[,] fields;
        private Cell[,] cells;
        private int rows;
        private int cols;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            if (timer1.Enabled)
                return; 

            npdDensity.Enabled = false;
            npdResolution.Enabled = false;
            resolution = (int)npdResolution.Value;
            rows = pictureBox1.Height/resolution;
            cols = pictureBox1.Width/resolution;
            fields  = new bool[cols, rows];
            cells = new Cell[cols, rows];
            Random rnd = new Random();
 
            for (int x = 0; x < cols; x++) 
            { 
            for (int y = 0; y < rows; y++) 
                {
                    fields[x,y] = rnd.Next((int)npdDensity.Value) == 0;
                    cells[x,y] = new Cell();
                    cells[x, y].isLife = fields[x, y];

                }
            }
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
        }

        private void NextGeneration()
        {
                    Brush result = PickBrush();
                    graphics.Clear(Color.White);
                    var newField = new bool[cols, rows];

                    for (int x = 0; x < cols; x++)
                    {
                        for (int y = 0; y < rows; y++)
                        {
                            var neighboursCount = CountNeighbours(x, y);
                            var hasLife = fields[x, y];

                            if (!hasLife && neighboursCount == 3)
                            {
                                newField[x, y] = true;
                                cells[x, y].generation++;
                            }


                            else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
                            {
                                newField[x, y] = false;
                                cells[x, y].generation = 0;
                            }


                            else
                            {
                                newField[x, y] = fields[x, y];
                                if (fields[x, y])
                                    cells[x, y].generation++;
                            }


                            if (!hasLife && newField[x, y])
                            {
                                graphics.FillRectangle(result, x * resolution, y * resolution, resolution, resolution);
                                cells[x, y].color = result;


                            }


                            else if (hasLife && newField[x, y])
                                graphics.FillRectangle(cells[x, y].color, x * resolution, y * resolution, resolution, resolution);

                        }
                    }
                    fields = newField;
                    pictureBox1.Refresh();
                
            

        }

        private int CountNeighbours(int x, int  y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;
                    var isSelfCheking = col == x && row == y;
                    var hasLife = fields[col, row]; 
                    if (hasLife && !isSelfCheking)
                        count++;
                }
            
            }
            return count;
        }
        //private Brush PickBrush()
        //{
        //    Brush result = Brushes.Transparent;

        //    Random rnd = new Random();

        //    Type brushesType = typeof(Brushes);

        //    PropertyInfo[] properties = brushesType.GetProperties();

        //    int random = rnd.Next(properties.Length);
        //    result = (Brush)properties[random].GetValue(null, null);

        //    return result;
        //}

        public Brush PickBrush()
        {

            Random r = new Random();
            SolidBrush brush = new SolidBrush(Color.FromArgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));

            return brush;
        }
        private void StopGame()
        {
            if (!timer1.Enabled)
                return;
            timer1.Stop();
            npdDensity.Enabled = true;
            npdResolution.Enabled = true;
        }
        private void bstart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void bstop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }
    }
}
