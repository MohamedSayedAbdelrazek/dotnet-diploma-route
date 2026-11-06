using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_OOP_Assignment_4
{
    internal abstract partial class Shipment
    {
        public string TrackingStatus { get; set; }

        public string GetTrackingStatus() {
            return TrackingStatus;
        }
        public void UpdateTrackingStatus(string status) {
            OnTrackingStatusChanged(status);
        }

        partial void OnTrackingStatusChanged(string newStatus);
    }
}
