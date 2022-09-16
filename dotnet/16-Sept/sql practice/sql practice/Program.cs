using System;

namespace sql_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            while (true)
            {
                snake.WriteBorad();
                snake.Input();
                snake.Logic();
            }
            Console.ReadKey();
        }
    }
}
