namespace G_NET68_OOP_Assignment_2
{
    internal struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAddress()
        {
            City = "Default";
            Street = "Default";
            BuildingNumber = 0;
        }

        public string GetFullAddress()
        {
            return $"{City}, {Street}, {BuildingNumber}";
        }

        public override string ToString()
        {
            return $"{City}, {Street}, {BuildingNumber}";
        }

    }
}
