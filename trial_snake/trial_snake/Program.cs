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
            //Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 26);
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(5, 7, '@');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80,25, '@');
            Point food = foodCreator.CreatorFood();
            food.Draw();

            while(true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail() )
                {
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreatorFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
        
        //static void Draw(Figure figure)
        //{
        //    figure.Drow();
        //}
    }
}

