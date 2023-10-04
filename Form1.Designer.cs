namespace CarRentingSystem {
    partial class ManageOrder {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblTitle = new Label();
            lblTypeOfCar = new Label();
            lblBrand = new Label();
            lblModel = new Label();
            lblSeatNum = new Label();
            label4 = new Label();
            txtTypeOfCar = new TextBox();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtSeatNum = new TextBox();
            txtDays = new TextBox();
            lblFuel = new Label();
            txtFuel = new TextBox();
            btnRentCar = new Button();
            btnPayment = new Button();
            lblTotalPrice = new Label();
            panelPayement = new Panel();
            btnPay = new Button();
            txtPaymentValue = new TextBox();
            lblPayment = new Label();
            lblChangeValue = new Label();
            lblChange = new Label();
            lblAmountToPayValue = new Label();
            lblAmountToPay = new Label();
            lblPaymentTitle = new Label();
            panelRent = new Panel();
            txtRentingSummary = new TextBox();
            panelPayement.SuspendLayout();
            panelRent.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(267, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(931, 128);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Car Renting System";
            // 
            // lblTypeOfCar
            // 
            lblTypeOfCar.AutoSize = true;
            lblTypeOfCar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTypeOfCar.Location = new Point(72, 211);
            lblTypeOfCar.Name = "lblTypeOfCar";
            lblTypeOfCar.Size = new Size(348, 25);
            lblTypeOfCar.TabIndex = 3;
            lblTypeOfCar.Text = "What type of car would you like to rent?";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBrand.Location = new Point(72, 327);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(293, 25);
            lblBrand.TabIndex = 4;
            lblBrand.Text = "What brand of car do you prefer?";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblModel.Location = new Point(72, 433);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(243, 25);
            lblModel.TabIndex = 5;
            lblModel.Text = "What model do you prefer?";
            // 
            // lblSeatNum
            // 
            lblSeatNum.AutoSize = true;
            lblSeatNum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSeatNum.Location = new Point(506, 211);
            lblSeatNum.Name = "lblSeatNum";
            lblSeatNum.Size = new Size(150, 25);
            lblSeatNum.TabIndex = 6;
            lblSeatNum.Text = "Number of seats";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(506, 328);
            label4.Name = "label4";
            label4.Size = new Size(325, 25);
            label4.TabIndex = 7;
            label4.Text = "How many days will you rent the car?";
            // 
            // txtTypeOfCar
            // 
            txtTypeOfCar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTypeOfCar.Location = new Point(72, 239);
            txtTypeOfCar.Name = "txtTypeOfCar";
            txtTypeOfCar.PlaceholderText = "Hybrid, Electric, Diesel, Others";
            txtTypeOfCar.Size = new Size(348, 29);
            txtTypeOfCar.TabIndex = 8;
            txtTypeOfCar.Leave += txtTypeOfCar_Leave;
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBrand.Location = new Point(72, 357);
            txtBrand.Name = "txtBrand";
            txtBrand.PlaceholderText = "Toyota, Honda, BMW, ...";
            txtBrand.Size = new Size(348, 29);
            txtBrand.TabIndex = 9;
            txtBrand.Leave += txtBrand_Leave;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtModel.Location = new Point(72, 461);
            txtModel.Name = "txtModel";
            txtModel.PlaceholderText = "Civic, Vios, Fortuner, ...";
            txtModel.Size = new Size(348, 29);
            txtModel.TabIndex = 10;
            // 
            // txtSeatNum
            // 
            txtSeatNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSeatNum.Location = new Point(506, 239);
            txtSeatNum.Name = "txtSeatNum";
            txtSeatNum.PlaceholderText = "4, 5, 7, 10, 15";
            txtSeatNum.Size = new Size(348, 29);
            txtSeatNum.TabIndex = 11;
            txtSeatNum.Leave += txtSeatNum_Leave;
            // 
            // txtDays
            // 
            txtDays.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDays.Location = new Point(506, 356);
            txtDays.Name = "txtDays";
            txtDays.PlaceholderText = "1, 2, 3, ...";
            txtDays.Size = new Size(348, 29);
            txtDays.TabIndex = 12;
            // 
            // lblFuel
            // 
            lblFuel.AutoSize = true;
            lblFuel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuel.Location = new Point(506, 433);
            lblFuel.Name = "lblFuel";
            lblFuel.Size = new Size(91, 25);
            lblFuel.TabIndex = 13;
            lblFuel.Text = "Fuel Type";
            lblFuel.Visible = false;
            // 
            // txtFuel
            // 
            txtFuel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuel.Location = new Point(506, 461);
            txtFuel.Name = "txtFuel";
            txtFuel.PlaceholderText = "0...";
            txtFuel.Size = new Size(348, 29);
            txtFuel.TabIndex = 14;
            txtFuel.Visible = false;
            // 
            // btnRentCar
            // 
            btnRentCar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRentCar.Location = new Point(343, 617);
            btnRentCar.Name = "btnRentCar";
            btnRentCar.Size = new Size(223, 81);
            btnRentCar.TabIndex = 15;
            btnRentCar.Text = "RENT CAR";
            btnRentCar.UseVisualStyleBackColor = true;
            btnRentCar.Click += btnRentCar_Click;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPayment.Location = new Point(1014, 791);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(423, 37);
            btnPayment.TabIndex = 16;
            btnPayment.Text = "PROCEED TO PAYMENT";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Visible = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(1014, 740);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 37);
            lblTotalPrice.TabIndex = 17;
            // 
            // panelPayement
            // 
            panelPayement.BackColor = SystemColors.ActiveCaption;
            panelPayement.Controls.Add(btnPay);
            panelPayement.Controls.Add(txtPaymentValue);
            panelPayement.Controls.Add(lblPayment);
            panelPayement.Controls.Add(lblChangeValue);
            panelPayement.Controls.Add(lblChange);
            panelPayement.Controls.Add(lblAmountToPayValue);
            panelPayement.Controls.Add(lblAmountToPay);
            panelPayement.Controls.Add(lblPaymentTitle);
            panelPayement.Location = new Point(2, 4);
            panelPayement.Name = "panelPayement";
            panelPayement.Size = new Size(1489, 855);
            panelPayement.TabIndex = 18;
            panelPayement.Visible = false;
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPay.Location = new Point(609, 640);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(251, 76);
            btnPay.TabIndex = 15;
            btnPay.Text = "ENTER PAYMENT";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // txtPaymentValue
            // 
            txtPaymentValue.Location = new Point(725, 432);
            txtPaymentValue.Name = "txtPaymentValue";
            txtPaymentValue.PlaceholderText = "0";
            txtPaymentValue.Size = new Size(261, 23);
            txtPaymentValue.TabIndex = 14;
            txtPaymentValue.Text = "0";
            txtPaymentValue.Leave += txtPaymentValue_Leave;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPayment.Location = new Point(482, 423);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(237, 32);
            lblPayment.TabIndex = 13;
            lblPayment.Text = "Enter your payment: ";
            // 
            // lblChangeValue
            // 
            lblChangeValue.AutoSize = true;
            lblChangeValue.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblChangeValue.Location = new Point(725, 515);
            lblChangeValue.Name = "lblChangeValue";
            lblChangeValue.Size = new Size(79, 32);
            lblChangeValue.TabIndex = 12;
            lblChangeValue.Text = "₱ 0.00";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblChange.Location = new Point(482, 515);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(108, 32);
            lblChange.TabIndex = 11;
            lblChange.Text = "Change: ";
            // 
            // lblAmountToPayValue
            // 
            lblAmountToPayValue.AutoSize = true;
            lblAmountToPayValue.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmountToPayValue.Location = new Point(725, 325);
            lblAmountToPayValue.Name = "lblAmountToPayValue";
            lblAmountToPayValue.Size = new Size(79, 32);
            lblAmountToPayValue.TabIndex = 10;
            lblAmountToPayValue.Text = "₱ 0.00";
            // 
            // lblAmountToPay
            // 
            lblAmountToPay.AutoSize = true;
            lblAmountToPay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmountToPay.Location = new Point(482, 325);
            lblAmountToPay.Name = "lblAmountToPay";
            lblAmountToPay.Size = new Size(186, 32);
            lblAmountToPay.TabIndex = 9;
            lblAmountToPay.Text = "Amount to pay: ";
            // 
            // lblPaymentTitle
            // 
            lblPaymentTitle.AutoSize = true;
            lblPaymentTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaymentTitle.Location = new Point(609, 138);
            lblPaymentTitle.Name = "lblPaymentTitle";
            lblPaymentTitle.Size = new Size(251, 65);
            lblPaymentTitle.TabIndex = 8;
            lblPaymentTitle.Text = "PAYMENT";
            // 
            // panelRent
            // 
            panelRent.BackColor = SystemColors.ActiveCaption;
            panelRent.Controls.Add(txtRentingSummary);
            panelRent.Controls.Add(lblTotalPrice);
            panelRent.Controls.Add(btnPayment);
            panelRent.Controls.Add(btnRentCar);
            panelRent.Controls.Add(txtFuel);
            panelRent.Controls.Add(lblFuel);
            panelRent.Controls.Add(txtDays);
            panelRent.Controls.Add(txtSeatNum);
            panelRent.Controls.Add(txtModel);
            panelRent.Controls.Add(txtBrand);
            panelRent.Controls.Add(txtTypeOfCar);
            panelRent.Controls.Add(label4);
            panelRent.Controls.Add(lblSeatNum);
            panelRent.Controls.Add(lblModel);
            panelRent.Controls.Add(lblBrand);
            panelRent.Controls.Add(lblTypeOfCar);
            panelRent.Controls.Add(lblTitle);
            panelRent.Location = new Point(3, 4);
            panelRent.Name = "panelRent";
            panelRent.Size = new Size(1488, 855);
            panelRent.TabIndex = 19;
            // 
            // txtRentingSummary
            // 
            txtRentingSummary.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtRentingSummary.Location = new Point(1014, 211);
            txtRentingSummary.Multiline = true;
            txtRentingSummary.Name = "txtRentingSummary";
            txtRentingSummary.ReadOnly = true;
            txtRentingSummary.ScrollBars = ScrollBars.Vertical;
            txtRentingSummary.Size = new Size(423, 487);
            txtRentingSummary.TabIndex = 18;
            txtRentingSummary.WordWrap = false;
            // 
            // ManageOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1493, 861);
            Controls.Add(panelRent);
            Controls.Add(panelPayement);
            Name = "ManageOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Renting";
            panelPayement.ResumeLayout(false);
            panelPayement.PerformLayout();
            panelRent.ResumeLayout(false);
            panelRent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblTypeOfCar;
        private Label lblBrand;
        private Label lblModel;
        private Label lblSeatNum;
        private Label label4;
        private TextBox txtTypeOfCar;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtSeatNum;
        private TextBox txtDays;
        private Label lblFuel;
        private TextBox txtFuel;
        public Button btnRentCar;
        private Button btnPayment;
        private Label lblTotalPrice;
        private Panel panelPayement;
        private Button btnPay;
        private TextBox txtPaymentValue;
        private Label lblPayment;
        private Label lblChangeValue;
        private Label lblChange;
        private Label lblAmountToPayValue;
        private Label lblAmountToPay;
        private Label lblPaymentTitle;
        private Panel panelRent;
        private TextBox txtRentingSummary;
    }
}