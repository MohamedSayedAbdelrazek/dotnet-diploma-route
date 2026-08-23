using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_OOP_Assignment_5
{
    internal partial class Shipment
    {
        public string TrackingStatus { get; set; }

        public string GetTrackingStatus() {
            return TrackingStatus;
        }
        public void UpdateTrackingStatus(string status) {
            TrackingStatus = status;
        }
    }
}
