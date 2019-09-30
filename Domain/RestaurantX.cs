using System;
using System.Collections.Generic;
using System.Text;

namespace ResturantX.Domian
{
    class RestaurantX
    {
        public string Name { get; set; }

    
        Queue<Order> orderQueue { get; set; } = new Queue<Order>(); // Kö lista

        public RestaurantX(string name)
        {
            Name = name;
        }
public void RegisterOrder(Order order)
        {
            orderQueue.Enqueue(order);
        }

    }
}
