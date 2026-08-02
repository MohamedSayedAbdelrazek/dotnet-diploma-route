using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace Assignment06
{
    internal class Shipment
    {

        private string trackingCode;
        private string description;
        private double weight;
        private double deliveryFee;
       
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

        public double Weight {
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
            get =>  deliveryFee;
            private set
            {
                if (value > 0)
                    deliveryFee = value;
                // else: invalid-> keep the old fee
            }
        }

        public DeliveryAddress Destination { get; set; }
        public double EstimatedCost  => DeliveryFee + (Weight * 5);
    }
}
