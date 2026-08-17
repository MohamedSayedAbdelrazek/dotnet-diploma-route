using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_OOP_Assignment_4
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight, double deliveryFee, string city, string street, int buildingNumber)
             : base(trackingCode, description, weight, deliveryFee, city, street, buildingNumber)
        {

        }
    }

}
