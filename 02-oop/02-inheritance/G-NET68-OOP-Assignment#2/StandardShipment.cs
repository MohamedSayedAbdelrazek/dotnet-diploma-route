namespace G_NET68_OOP_Assignment_2
{
    internal class StandardShipment:Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination) 
            :base(trackingCode,description,weight,deliveryFee,destination) 
        { 
        
        }
    }
}
