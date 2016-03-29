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

            HandleKey(snake);
            
            Console.ReadLine();
        }

        private static void HandleKey(Snake snake)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo info = Console.ReadKey();
                    if (info.Key == ConsoleKey.LeftArrow)
                    {
                        snake.direction = Direction.LEFT;
                    }
                    else if (info.Key == ConsoleKey.RightArrow)
                    {
                        snake.direction = Direction.RIGHT;
                    }
                    else if (info.Key == ConsoleKey.DownArrow)
                    {
                        snake.direction = Direction.DOWN;
                    }
                    else if (info.Key == ConsoleKey.UpArrow)
                    {
                        snake.direction = Direction.UP;
                    }
                }
                Thread.Sleep(300);
                snake.Move();
            }
        }

    }
}

