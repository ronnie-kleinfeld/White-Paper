﻿
namespace Testability
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool isShipped
        {
            get => Shipment != null;
        }
    }
}