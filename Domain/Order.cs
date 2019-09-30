﻿using System;

namespace ResturantX.Domian
{
    class Order
    {
        public string Dish { get; }
        public string Table { get; }
        public DateTime RegisteredAt { get; } = DateTime.Now;
        public DateTime? StartedAt { get; }
        public DateTime? CompletedAt { get; }

        public Order(string dish, string table)
        {
            Dish = dish;
            Table = table;
        }
    }
}
