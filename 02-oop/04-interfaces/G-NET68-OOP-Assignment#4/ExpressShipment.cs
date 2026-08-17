using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_OOP_Assignment_4
{
    internal class ExpressShipment : Shipment
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
        public override double EstimatedCost => base.EstimatedCost + ExtraFee;

        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Extra Fee {ExtraFee}");
        }
    }
}
