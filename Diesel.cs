using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem {
    public class Diesel : Cars {
        public double fuelEfficiency { get; set; }
        public Diesel(string brand, string model, int seatNum, int days, double fuelEfficiency) : base(brand, model, seatNum, days) {
            this.fuelEfficiency = fuelEfficiency;
        }
        public override void showCarDetails(Label lbl) {
            base.showCarDetails(lbl);
            lbl.Text += $"\nFuel Efficiency: {fuelEfficiency} mpg";
        }
    }
}
