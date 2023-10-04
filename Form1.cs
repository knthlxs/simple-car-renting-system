using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentingSystem {
    public partial class ManageOrder : Form {
        List<Cars> rentedCar = new List<Cars>();
        Cars car = new Cars();
        public double totalPrice, payment, change;

        // RETURNS AN ERROR IF THIS BLOCK OF CODE IS MISSING... WHY?
        //public double TotalPrice {
        //    get {
        //        return totalPrice = double.Parse(lblTotalPrice.Text);
        //    }
        //}
        public ManageOrder() {
            InitializeComponent();

        }

        private void getOrder() {
            string carType = txtTypeOfCar.Text;
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            int seatNum = Convert.ToInt32(txtSeatNum.Text);
            int days = Convert.ToInt32(txtDays.Text);

            switch (carType.ToLower()) {
                case "hybrid": {
                    double fuelEconomy = double.Parse(txtFuel.Text);
                    rentedCar.Add(new Hybrid(brand, model, seatNum, days, fuelEconomy));
                    break;
                }
                case "electric": {
                    double batteryRange = double.Parse(txtFuel.Text);
                    rentedCar.Add(new Electric(brand, model, seatNum, days, batteryRange));
                    break;
                }
                case "diesel": {
                    double fuelEffieciency = double.Parse(txtFuel.Text);
                    rentedCar.Add(new Diesel(brand, model, seatNum, days, fuelEffieciency));
                    break;
                }
                default: {
                    rentedCar.Add(new Cars(brand, model, seatNum, days));
                }
                break;
            }
        }

        public double calculateTotalPrice(double price, int days) {
            totalPrice += price * days;
            return totalPrice;
        }

        public double getTotalPrice() {
            return totalPrice;
        }

        private void displayOrder() {

            if (!string.IsNullOrEmpty(this.txtTypeOfCar.Text) && !string.IsNullOrEmpty(this.txtBrand.Text) && !string.IsNullOrEmpty(this.txtModel.Text) && !string.IsNullOrEmpty(this.txtSeatNum.Text) && !string.IsNullOrEmpty(this.txtDays.Text)) {
                txtRentingSummary.Text += "RENTING SUMMARY";

                foreach (var car in rentedCar) {
                    if (car is Hybrid) {
                        txtRentingSummary.Text += "\r\n\r\nType of Car: Hybrid\r\n";
                    } else if (car is Electric) {
                        txtRentingSummary.Text += "\r\n\r\nType of Car: Electric\r\n";
                    } else if (car is Diesel) {
                        txtRentingSummary.Text += "\r\n\r\nType of Car: Diesel\r\n";
                    } else {
                        txtRentingSummary.Text += "\r\n\r\nType of Car: Others\r\n";
                    }
                    totalPrice = calculateTotalPrice(car.getPrice(), car.days);

                    car.showCarDetails(txtRentingSummary);
                }
                //btnRentAgain.Visible = true;
                lblTotalPrice.Text = $"Total Price: ₱ {totalPrice.ToString()}.00";
            } else {
                MessageBox.Show("Please input all required fields.");
            }

        }


        private void txtTypeOfCar_Leave(object sender, EventArgs e) {
            if (txtTypeOfCar.Text.ToLower().Equals("hybrid")) {
                lblFuel.Text = "Fuel Economy (mpg)";
                txtFuel.Visible = true;
                lblFuel.Visible = true;
            } else if (txtTypeOfCar.Text.ToLower().Equals("electric")) {
                lblFuel.Text = "Battery Range (miles)";
                txtFuel.Visible = true;
                lblFuel.Visible = true;

            } else if (txtTypeOfCar.Text.ToLower().Equals("diesel")) {
                lblFuel.Text = "Fuel Efficiency (mpg)";
                txtFuel.Visible = true;
                lblFuel.Visible = true;

            } else {
                lblFuel.Text = "";
                txtFuel.Visible = false;
            }
        }

        private void clearAllText() {
            txtTypeOfCar.Text = string.Empty;
            txtBrand.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtSeatNum.Text = string.Empty;
            txtDays.Text = string.Empty;
            txtFuel.Text = string.Empty;
            lblFuel.Visible = false;
            txtFuel.Visible = false;
        }


        private void btnRentCar_Click(object sender, EventArgs e) {
            try {
                getOrder();

                DialogResult choice = MessageBox.Show("Do you want to rent another car?", "Rent another car", MessageBoxButtons.YesNo);

                if (choice == DialogResult.No) {
                    btnRentCar.Visible = false;
                    displayOrder();
                    btnPayment.Visible = true;
                }
                clearAllText();
            } catch (Exception) {
                MessageBox.Show("Invalid input, please try again.");
            }


        }

        private void btnPayment_Click(object sender, EventArgs e) {
            //lblAmountToPayValue.Text = TotalPrice.ToString();
            lblAmountToPayValue.Text = $"₱ {totalPrice.ToString()}.00";
            panelRent.Visible = false;
            panelPayement.Visible = true;


        }
        /*PROBLEM
         
         */
        private void txtPaymentValue_Leave(object sender, EventArgs e) {
            try {
                payment = Convert.ToDouble(txtPaymentValue.Text);

                if (payment >= totalPrice) {
                    lblChange.Visible = true;
                    lblChangeValue.Visible = true;

                    change = payment - totalPrice;

                    lblChangeValue.Text = $"₱ {change.ToString()}.00";
                }
            } catch (FormatException) {
                MessageBox.Show("Please input a number only.", "Invalid input");
            }


        }

        private void btnPay_Click(object sender, EventArgs e) {
            try {
                payment = Convert.ToDouble(txtPaymentValue.Text);
                if (payment >= totalPrice) {
                    MessageBox.Show("Payment success. Thank you for renting car on our shop!");
                    panelRent.Visible = true;
                    panelPayement.Visible = false;
                    totalPrice = 0;
                    rentedCar.Clear();
                    txtRentingSummary.Text = string.Empty;
                    lblTotalPrice.Text = string.Empty;
                    lblChange.Visible = false;
                    lblChangeValue.Visible = false;
                    btnRentCar.Visible = true;
                    btnPayment.Visible = false;
                    payment = 0;
                    txtPaymentValue.Text = payment.ToString();

                } else {
                    MessageBox.Show("Insufficient balance, please try again.");
                }
            } catch (FormatException) {
                MessageBox.Show("Please input a number only.", "Invalid input");
            }

        }
    }
}