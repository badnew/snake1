using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Установка размера буффера консоли. Не должен быть меньше текущего размера консоли.
            Console.SetBufferSize(80, 25);

            // Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(1, 78, 0, '-');
            HorizontalLine downLine = new HorizontalLine(1, 78, 24, '-');
            VerticalLine leftLine = new VerticalLine(0, 24, 1, '|');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '|');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            // Отрисовка точки
            Point p = new Point(4, 5, '*');
            p.Draw();



            Console.ReadLine();
        }
    }
}