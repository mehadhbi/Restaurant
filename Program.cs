using System;
using static System.Console;

namespace Resturant
{
    class Program
    {
        static void Main(string[] args)
        {

            bool shouldNotExit = true;

            while (shouldNotExit)
            {
                Clear();

                WriteLine("1. Add order");
                WriteLine("2. List orders");
                WriteLine("3. Exit");

                ConsoleKeyInfo keyPressed = ReadKey();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:

                        break;

                    case ConsoleKey.D2:

                        break;

                    case ConsoleKey.D3:
                        shouldNotExit = false;
                        break;

                    default:
                        break;
                }
            }

        }
    }
}
