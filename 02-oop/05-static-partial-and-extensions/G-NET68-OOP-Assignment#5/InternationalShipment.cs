using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_OOP_Assignment_4
{
    internal class InternationalShipment : Shipment,ITrackable, IInsurable
    {
        public InternationalShipment(string trackingCode, string description, double weight, double deliveryFee, string city, string street, int buildingNumber, string destinationCountry, double customFee)
             : base(trackingCode, description, weight, deliveryFee, city, street, buildingNumber)
        {
            CustomsFee = customFee;
            DestinationCountry = destinationCountry;
        }

        public string DestinationCountry
        {
            get => field;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Value is not valid");
                else
                    field = value;
            }
        }

        public double CustomsFee
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
        public override double EstimatedCost => DeliveryFee + (Weight * 5) + CustomsFee;

        public override void PrintShipment()
        {
            Console.WriteLine(
                    $"\nTracking Code: {TrackingCode}\n Description: {Description}\n Weight: {Weight}\n DeliveryFee: " +
                    $"{DeliveryFee}\n Destination: {Destination}\n EstimatedCost: {EstimatedCost}"
                    );

            Console.WriteLine($"Destination country: {DestinationCountry}\n Custom Fee: {CustomsFee}");
        }

        public virtual void GenerateCustomsReport()
        {

        }

        public string GetTrackingStatus()
        {
            return "Ready";
        }

        public double CalculateInsurance()
        {
            return EstimatedCost * 0.12;
        }
    }

}
