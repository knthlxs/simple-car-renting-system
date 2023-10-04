﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem {
    public class Cars {
        public string brand { get; set; }
        public string model { get; set; }


        public int seatNum, days;
        private const double PRICE = 3000;
        public double getPrice() {
            return PRICE;
        }
        public Cars() {


        }
        
        public Cars(string brand, string model, int seatNum, int days) {
            this.brand = brand;
            this.model = model;
            this.seatNum = seatNum;
            this.days = days;
        }

        public virtual void showCarDetails(Label lbl) {
            lbl.Text += $"Brand: {brand}\nModel: {model}\nNo. of seats: {seatNum}\nNo. of days: {days}";
        }
    }
}
