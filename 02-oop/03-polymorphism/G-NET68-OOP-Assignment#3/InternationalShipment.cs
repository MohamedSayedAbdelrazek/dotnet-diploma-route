using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_OOP_Assignment_3
{
    internal class InternationalShipment : Shipment
    {
        public InternationalShipment(string trackingCode, string description, double weight, double deliveryFee, string city,string street,int buildingNumber, string destinationCountry, double customFee)
             : base(trackingCode, description, weight, deliveryFee, city,street,buildingNumber)
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
        public override double EstimatedCost => base.EstimatedCost + CustomsFee;

        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Destination country: {DestinationCountry}\n Custom Fee: {CustomsFee}");
        }

        public virtual void GenerateCustomsReport() {
        
        }
    }

}
