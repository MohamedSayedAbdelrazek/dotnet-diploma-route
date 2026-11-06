using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_OOP_Assignment_4
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        public ExpressShipment(string trackingCode, string description, double weight, double deliveryFee, string city, string street, int buildingNumber, double extraFee)
             : base(trackingCode, description, weight, deliveryFee, city, street, buildingNumber)
        {
            ExtraFee = extraFee;
        }
        public double ExtraFee
        {

            get => field;

            set
            {
                if (value >= 0)
                    field = value;
                else
                    throw new ArgumentException("Value must be non-negative number");
            }

        }
        public override double EstimatedCost => DeliveryFee + (Weight * 5)+ExtraFee;

        public double CalculateInsurance()
        {
            return EstimatedCost * 0.08;
        }

        public string GetTrackingStatus()
        {
            return "Out for Delivery.";
        }

        public override void PrintShipment()
        {
            {
                Console.WriteLine(
                    $"\nTracking Code: {TrackingCode}\n Description: {Description}\n Weight: {Weight}\n DeliveryFee: " +
                    $"{DeliveryFee}\n Destination: {Destination}\n EstimatedCost: {EstimatedCost}\n Extra Fee {ExtraFee}"
                    );
                Console.WriteLine("-------------------------------------------------");
            }
        }
    }
}
