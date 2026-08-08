namespace G_NET68_OOP_Assignment_2
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments;
        public int Size { get; }
        public string CenterName { get; set; } 
        public DeliveryCenter(int size=20)
        {
            Size = size;
            shipments = new Shipment[size];
        }

        public Shipment? this[int index]
        {
            get
            {
                if (shipments != null)
                {
                    if (index < Size)
                    {
                        return shipments[index];
                    }
                }
                return null;
            }

            set
            {
                if (shipments != null)
                {
                    if (index >= 0 && index < Size)
                    {
                        shipments[index] = value;
                    }
                }
            }
        }

        public Shipment? this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < Size; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }
                return null;
            }

        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < Size; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode) {
            for (int i = 0; i < shipments.Length; i++) {
                if (shipments[i]?.TrackingCode == trackingCode) { 
                    shipments[i] = null; // Remove the shipment
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments() { 
            for(int i=0;i<shipments.Length;i++)
                shipments[i]?.PrintShipment();
        }


}
}
