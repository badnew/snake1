using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class VerticalLine : Figure
    {
        // конструктор
        public VerticalLine(int yUpper, int yLower, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUpper; y <= yLower; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
