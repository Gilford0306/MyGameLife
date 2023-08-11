using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLife
{
    internal class Cell
    {
        public bool isLife { get; set; }
        public int X { get; set; }  
        public int Y { get; set; }

        public int generation = 0;
        public Brush color = Brushes.White;

        public Cell() { }

        public Cell(bool isLife, int x, int y, Brush brush)
        {
            this.isLife = isLife;
            X = x;
            Y = y;
            color = brush;
        }
    }
}
