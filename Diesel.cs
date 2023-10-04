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
        public override void showCarDetails(TextBox txt) {
            base.showCarDetails(txt);
            txt.Text += $"\r\nFuel Efficiency: {fuelEfficiency} mpg";
        }
    }
}
