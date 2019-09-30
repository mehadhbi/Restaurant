using ResturantX.Domian;
using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantX restaurant = new RestaurantX("MaxDonalds");

            bool shouldNotExit = true;

            while (shouldNotExit)
            {
                WriteLine("1. Register order");
                WriteLine("2. List orders");
                WriteLine("3. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:


                        Write("Dish: ");

                        string dish = ReadLine();

                        Write("Table: ");

                        string table = ReadLine();

                        Order order = new Order(dish, table);

                        restaurant.RegisterOrder(order);


                        Clear();

                        WriteLine("Order registered");

                        Thread.Sleep(2000); // 2 sek

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        shouldNotExit = false;

                        break;
                }

                Clear();
            }

        }
    }
}



// Order[]
// List<Order>
// Queue<Order>   FIFO
// Stack<Order>  LIFO