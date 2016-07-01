using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Установка размера буффера консоли
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

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.handleKey(key.Key);
                }
            }
        }
    }
}