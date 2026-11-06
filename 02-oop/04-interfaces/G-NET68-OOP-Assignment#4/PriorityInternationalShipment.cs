using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_OOP_Assignment_4
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, double weight, double deliveryFee, string city, string street, int buildingNumber, string destinationCountry, double customFee)
             : base(trackingCode, description, weight, deliveryFee, city, street, buildingNumber, destinationCountry, customFee)
        {

        }

        public override sealed void GenerateCustomsReport()
        {
            base.GenerateCustomsReport();
            //add the overriden logic
        }
    }
}
