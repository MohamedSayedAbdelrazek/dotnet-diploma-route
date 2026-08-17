using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_OOP_Assignment_4
{
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string trackingCode, string description, double weight, double deliveryFee, string city, string street, int buildingNumber)
             : base(trackingCode, description, weight, deliveryFee, city, street, buildingNumber)
        {

        }

        public override double EstimatedCost=> DeliveryFee + (Weight * 5);

        public double CalculateInsurance()
        {
            return  EstimatedCost * 0.05;
        }

        public string GetTrackingStatus()
        {
            return " has been Delivered.";
        }

        public override void PrintShipment()
        {
            Console.WriteLine(
                $"\nTracking Code: {TrackingCode}\n Description: {Description}\n Weight: {Weight}\n DeliveryFee: {DeliveryFee}\n Destination: {Destination}\n EstimatedCost: {EstimatedCost}"
                );
            Console.WriteLine("-------------------------------------------------");
        }
    }

}
