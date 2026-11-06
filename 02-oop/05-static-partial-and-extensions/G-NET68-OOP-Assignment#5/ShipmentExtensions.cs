using G_NET68_OOP_Assignment_4;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace G_NET68_OOP_Assignment_5
{
    internal static class ShipmentExtensions
    {
        internal static string GetSummary(this Shipment shipment) {
            return $"{shipment.TrackingCode} | {shipment.GetType()} | {shipment.Weight} | {shipment.Destination}";
        }

        internal static bool IsDelivered(this Shipment shipment)
        {
            return shipment.TrackingStatus == "Deliverd";
        }
    }
}
