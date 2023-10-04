using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem {
    public class Hybrid : Cars{
        public double fuelEconomy { get; set; }
        public Hybrid(string brand, string model, int seatNum, int days, double fuelEconomy) : base(brand, model,seatNum, days)
        {
            this.fuelEconomy = fuelEconomy;
        }

        public override void showCarDetails(TextBox txt) {
            base.showCarDetails(txt);
            txt.Text += $"\r\nFuel Economy: {fuelEconomy} mpg";
        }
    }
}
