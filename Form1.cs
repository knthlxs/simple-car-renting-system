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
        public double totalPrice, payment, change;
        private byte[] seatNum = { 4, 5, 7, 10, 15 };
        private bool correctSeat = false;
        private bool correctBrand = false;
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
                    break;
                }
            }
        }

        public double calculateTotalPrice(double price, int days) {
            totalPrice += price * days;
            return totalPrice;
        }

        private void displayOrder() {
            if (!string.IsNullOrEmpty(this.txtTypeOfCar.Text) && !string.IsNullOrEmpty(this.txtBrand.Text) && !string.IsNullOrEmpty(this.txtModel.Text) && !string.IsNullOrEmpty(this.txtSeatNum.Text) && !string.IsNullOrEmpty(this.txtDays.Text)) {

                getOrder();

                DialogResult choice = MessageBox.Show("Do you want to rent another car?", "Rent another car", MessageBoxButtons.YesNo);
                if (choice == DialogResult.No) {

                    hideTxtField();

                    btnRentCar.Visible = false;
                    btnPayment.Visible = true;

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
                    lblTotalPrice.Text = $"Total Price: ₱ {totalPrice.ToString()}.00";
                } else {
                    clearAllText();

                }
            } else {
                MessageBox.Show("Please input all required fields.", "Incomplete field");
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
            } else if (txtTypeOfCar.Text.ToLower().Equals("others")) {
                lblFuel.Text = "";
                txtFuel.Visible = false;
            } else {
                MessageBox.Show("Please input correct car type (Hybrid, Electric, Diesel, Others) only.", "Invalid car type");
                txtTypeOfCar.Text = "";
            }
        }

        private void showTxtField() {
            lblTypeOfCar.Visible = true;
            txtTypeOfCar.Visible = true;
            lblBrand.Visible = true;
            txtBrand.Visible = true;
            lblModel.Visible = true;
            txtModel.Visible = true;
            lblSeatNum.Visible = true;
            txtSeatNum.Visible = true;
            lblDays.Visible = true;
            txtDays.Visible = true;
            lblFuel.Visible = true;
            txtFuel.Visible = true;
        }

        private void hideTxtField() {
            lblTypeOfCar.Visible = false;
            txtTypeOfCar.Visible = false;
            lblBrand.Visible = false;
            txtBrand.Visible = false;
            lblModel.Visible = false;
            txtModel.Visible = false;
            lblSeatNum.Visible = false;
            txtSeatNum.Visible = false;
            lblDays.Visible = false;
            txtDays.Visible = false;
            lblFuel.Visible = false;
            txtFuel.Visible = false;
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
                displayOrder();
            } catch (FormatException) {
                MessageBox.Show("PLease input all fields.");
            }

        }

        private void btnPayment_Click(object sender, EventArgs e) {
            lblAmountToPayValue.Text = $"₱ {totalPrice.ToString()}.00";
            panelRent.Visible = false;
            panelPayement.Visible = true;
        }

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
                    MessageBox.Show("Payment success. Thank you for renting car on our shop!", "Payment success");
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
                    clearAllText();
                    showTxtField();
                } else {
                    MessageBox.Show("Insufficient balance, please try again.");
                }
            } catch (FormatException) {
                MessageBox.Show("Please input a number only.", "Invalid input");
            }

        }

        private void txtSeatNum_Leave(object sender, EventArgs e) {
            try {
                if ((Convert.ToByte(txtSeatNum.Text) == 4) || (Convert.ToByte(txtSeatNum.Text) == 5) || (Convert.ToByte(txtSeatNum.Text) == 7) || (Convert.ToByte(txtSeatNum.Text) == 10) || (Convert.ToByte(txtSeatNum.Text) == 15)) {
                    correctSeat = true;
                } else {
                    MessageBox.Show("Please input correct car seat number (4, 5, 7, 10, 15) only.", "Invalid car type");
                    txtSeatNum.Text = "";
                }
            } catch (FormatException) {
                MessageBox.Show("Please input a number");
            }
        }

        private void txtBrand_Leave(object sender, EventArgs e) {
            if ((txtBrand.Text.ToLower() == "toyota") || (txtBrand.Text.ToLower() == "honda") || (txtBrand.Text.ToLower() == "mitsubishi") || (txtBrand.Text.ToLower() == "ford") || (txtBrand.Text.ToLower() == "nissan") || (txtBrand.Text.ToLower() == "suzuki")) {
                correctBrand = true;
            } else {
                MessageBox.Show("Please input correct car brand (Toyota, Honda, Mitsubishi, Ford, Nissan) only.", "Invalid car brand");
                txtBrand.Text = "";
            }
        }



        private void txtPaymentValue_Click(object sender, EventArgs e) {
            txtPaymentValue.Text = "";
        }

        private void txtDays_Leave(object sender, EventArgs e) {
            try {
                if (Convert.ToByte(txtDays.Text) < 1) {
                    txtDays.Text = "1";
                    MessageBox.Show("Days should be greater than or equal to 1", "Invalid input");
                }
            } catch (OverflowException) {
                txtDays.Text = "1";
                MessageBox.Show("Please input positive number of days only.", "Invalid input");
            } catch (FormatException) {
                txtDays.Text = "1";
                MessageBox.Show("Please input positive number of days only.", "Invalid input");
            }
        }

        private void txtDays_Click(object sender, EventArgs e) {
            txtDays.Text = "";
        }

        /*TO CODE
         Days must be greater than 0
         */
    }
}