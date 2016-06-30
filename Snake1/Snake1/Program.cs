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
            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();

            VerticalLine line1 = new VerticalLine(0, 10, 20, '#');
            line1.Drow();

            Console.ReadLine();
        }
    }
}