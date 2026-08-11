using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_OOP_Assignment_3
{
    internal class Shipment
    {

        private string trackingCode;
        private string description;
        private double weight;
        private double deliveryFee;

        public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            Destination = default;

        }

        public Shipment(string trackingCode, string description, double weight, double deliveryFee, string city, string street, int buldingNumber)
        {
            this.trackingCode = trackingCode;
            this.description = description;
            this.weight = weight;
            this.deliveryFee = deliveryFee;
            Destination = new DeliveryAddress(city,street,buldingNumber);
        }

        public string TrackingCode => trackingCode;

        public string Description
        {
            get => description;

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
                // else: invalid -> keep the old description
            }
        }

        public double Weight
        {
            get => weight;

            set
            {
                if (value > 0)
                    weight = value;
                // else: invalid -> keep the old weight
            }

        }

        public double DeliveryFee
        {
            get => deliveryFee;
            private set
            {
                if (value > 0)
                    deliveryFee = value;
                // else: invalid-> keep the old fee
            }
        }

        public DeliveryAddress Destination { get; }
        public virtual double EstimatedCost => DeliveryFee + (Weight * 5);

        public void UpdateDeliveryFee(double newFee)
        {
            if (newFee > 0)
                deliveryFee = newFee;
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine(
                $"\nTracking Code: {trackingCode}\n Description: {Description}\n Weight: {weight}\n DeliveryFee: {deliveryFee}\n Destination: {Destination}\n EstimatedCost: {EstimatedCost}"
                );
            Console.WriteLine("-------------------------------------------------");
        }

        public void UpdateWeight(double weight){
            Weight = weight;
        }

        public void UpdateWeight(double weight, double extraPackingWeight) {
            Weight = weight + extraPackingWeight;
        }

    }

}
