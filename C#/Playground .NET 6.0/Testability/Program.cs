﻿namespace Testability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShiipingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}