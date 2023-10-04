using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem {
    public class Electric : Cars {
        public double batteryRange { get; set; }
        public Electric(string brand, string model, int seatNum, int days, double batteryRange) : base(brand, model, seatNum, days) {
            this.batteryRange = batteryRange;
        }

        public override void showCarDetails(Label lbl) {
            base.showCarDetails(lbl);
            lbl.Text += $"\nBattery Range: {batteryRange} miles";
        }
    }
}
