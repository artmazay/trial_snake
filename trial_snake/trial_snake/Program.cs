using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using trial_snake;
//using Snake;

namespace trial_snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontalLine lineUp = new HorizontalLine(0, 78, 0, '*');
            VerticalLine lineLeft = new VerticalLine(0, 23, 0, '*');
            HorizontalLine lineDown = new HorizontalLine(0, 78, 23, '*');
            VerticalLine lineRight = new VerticalLine(0, 23, 78, '*');
            lineUp.Drow();
            lineDown.Drow();
            lineLeft.Drow();
            lineRight.Drow();


            Point p2 = new Point(10, 5, '*');
            Snake snake = new Snake(p2, 5, Direction.RIGHT);
            snake.Drow();

            FoodCreator food = new FoodCreator(78, 23, '@');
            Point f = food.CreatorFood();
            f.Draw();

            while (true)
            {
                if(snake.Eat(f))
                {
                    f = food.CreatorFood();
                    f.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(200);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo info = Console.ReadKey();
                    snake.HandleKey(info.Key);
                }
            }
        }
    }
}

