using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace G_NET68_OOP_Assignment_4
{
    internal sealed class CompletedShipment : Shipment
    {

        CompletedShipment(string trackingCode, string description, double weight, double deliveryFee, string city, string street, int buldingNumber)
             : base(trackingCode, description, weight, deliveryFee, city, street, buldingNumber) { }

        public override double EstimatedCost => DeliveryFee + (Weight * 5);

        public override void PrintShipment()
        {
            Console.WriteLine(
                        $"\nTracking Code: {TrackingCode}\n Description: {Description}\n Weight: {Weight}\n DeliveryFee: {DeliveryFee}\n Destination: {Destination}\n EstimatedCost: {EstimatedCost}"
                        );
            Console.WriteLine("-------------------------------------------------");

        }
    }
}
