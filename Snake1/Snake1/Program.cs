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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            // создание нового списка с символами
            List<char> charList = new List<char>();
            charList.Add('*');
            charList.Add('#');
            charList.Add('+');

            foreach(char j in charList)
            {
                Console.WriteLine(j);
            }

            // создание дополнительных точек
            Point p3 = new Point(10, 23, '$');
            Point p4 = new Point(34, 3, '@');
            Point p5 = new Point(2, 18, '%');

            // создание нового списка с объектами класса Point
            List<Point> pointList = new List<Point>();
            pointList.Add(p3);
            pointList.Add(p4);
            pointList.Add(p5);

            foreach(Point k in pointList)
            {
                Console.WriteLine(k.sym);
            }

            foreach (Point k in pointList)
            {
                k.Draw();
            }

            Console.ReadLine();
        }
    }
}