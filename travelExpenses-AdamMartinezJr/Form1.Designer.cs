namespace travelExpenses_AdamMartinezJr
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pane = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.receiptTB = new System.Windows.Forms.TextBox();
            this.receipt = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lodgingTB = new System.Windows.Forms.TextBox();
            this.semRegFeeTB = new System.Windows.Forms.TextBox();
            this.taxiFeeTB = new System.Windows.Forms.TextBox();
            this.parkFeeTB = new System.Windows.Forms.TextBox();
            this.milesTB = new System.Windows.Forms.TextBox();
            this.carRentalTB = new System.Windows.Forms.TextBox();
            this.flightsTB = new System.Windows.Forms.TextBox();
            this.daysTB = new System.Windows.Forms.TextBox();
            this.lodgingCharge = new System.Windows.Forms.Label();
            this.SemRegFee = new System.Windows.Forms.Label();
            this.taxiFee = new System.Windows.Forms.Label();
            this.parkFee = new System.Windows.Forms.Label();
            this.milesDriven = new System.Windows.Forms.Label();
            this.carRental = new System.Windows.Forms.Label();
            this.Flights = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalBTN = new System.Windows.Forms.Button();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.subTotalTB = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pane.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pane
            // 
            this.pane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pane.Controls.Add(this.Title);
            this.pane.Location = new System.Drawing.Point(12, 12);
            this.pane.Name = "pane";
            this.pane.Size = new System.Drawing.Size(604, 100);
            this.pane.TabIndex = 3;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(569, 77);
            this.Title.TabIndex = 0;
            this.Title.Text = "Travel Expenses v1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.receiptTB);
            this.panel1.Controls.Add(this.receipt);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnReceipt);
            this.panel1.Location = new System.Drawing.Point(793, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 518);
            this.panel1.TabIndex = 4;
            // 
            // receiptTB
            // 
            this.receiptTB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptTB.Location = new System.Drawing.Point(11, 52);
            this.receiptTB.Multiline = true;
            this.receiptTB.Name = "receiptTB";
            this.receiptTB.Size = new System.Drawing.Size(345, 388);
            this.receiptTB.TabIndex = 4;
            // 
            // receipt
            // 
            this.receipt.AutoSize = true;
            this.receipt.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt.Location = new System.Drawing.Point(122, 11);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(136, 38);
            this.receipt.TabIndex = 3;
            this.receipt.Text = "Receipt";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(201, 458);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 53);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.Location = new System.Drawing.Point(11, 458);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(155, 53);
            this.btnReceipt.TabIndex = 1;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lodgingTB);
            this.panel2.Controls.Add(this.semRegFeeTB);
            this.panel2.Controls.Add(this.taxiFeeTB);
            this.panel2.Controls.Add(this.parkFeeTB);
            this.panel2.Controls.Add(this.milesTB);
            this.panel2.Controls.Add(this.carRentalTB);
            this.panel2.Controls.Add(this.flightsTB);
            this.panel2.Controls.Add(this.daysTB);
            this.panel2.Controls.Add(this.lodgingCharge);
            this.panel2.Controls.Add(this.SemRegFee);
            this.panel2.Controls.Add(this.taxiFee);
            this.panel2.Controls.Add(this.parkFee);
            this.panel2.Controls.Add(this.milesDriven);
            this.panel2.Controls.Add(this.carRental);
            this.panel2.Controls.Add(this.Flights);
            this.panel2.Controls.Add(this.numDays);
            this.panel2.Location = new System.Drawing.Point(12, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 354);
            this.panel2.TabIndex = 5;
            // 
            // lodgingTB
            // 
            this.lodgingTB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodgingTB.Location = new System.Drawing.Point(351, 282);
            this.lodgingTB.Multiline = true;
            this.lodgingTB.Name = "lodgingTB";
            this.lodgingTB.Size = new System.Drawing.Size(66, 31);
            this.lodgingTB.TabIndex = 15;
            this.lodgingTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // semRegFeeTB
            // 
            this.semRegFeeTB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semRegFeeTB.Location = new System.Drawing.Point(351, 245);
            this.semRegFeeTB.Multiline = true;
            this.semRegFeeTB.Name = "semRegFeeTB";
            this.semRegFeeTB.Size = new System.Drawing.Size(66, 31);
            this.semRegFeeTB.TabIndex = 14;
            this.semRegFeeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // taxiFeeTB
            // 
            this.taxiFeeTB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxiFeeTB.Location = new System.Drawing.Point(351, 208);
            this.taxiFeeTB.Multiline = true;
            this.taxiFeeTB.Name = "taxiFeeTB";
            this.taxiFeeTB.Size = new System.Drawing.Size(66, 31);
            this.taxiFeeTB.TabIndex = 13;
            this.taxiFeeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // parkFeeTB
            // 
            this.parkFeeTB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkFeeTB.Location = new System.Drawing.Point(351, 171);
            this.parkFeeTB.Multiline = true;
            this.parkFeeTB.Name = "parkFeeTB";
            this.parkFeeTB.Size = new System.Drawing.Size(66, 31);
            this.parkFeeTB.TabIndex = 12;
            this.parkFeeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // milesTB
            // 
            this.milesTB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesTB.Location = new System.Drawing.Point(351, 133);
            this.milesTB.Multiline = true;
            this.milesTB.Name = "milesTB";
            this.milesTB.Size = new System.Drawing.Size(70, 31);
            this.milesTB.TabIndex = 11;
            this.milesTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // carRentalTB
            // 
            this.carRentalTB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carRentalTB.Location = new System.Drawing.Point(351, 96);
            this.carRentalTB.Multiline = true;
            this.carRentalTB.Name = "carRentalTB";
            this.carRentalTB.Size = new System.Drawing.Size(70, 31);
            this.carRentalTB.TabIndex = 10;
            this.carRentalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flightsTB
            // 
            this.flightsTB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightsTB.Location = new System.Drawing.Point(351, 59);
            this.flightsTB.Multiline = true;
            this.flightsTB.Name = "flightsTB";
            this.flightsTB.Size = new System.Drawing.Size(70, 31);
            this.flightsTB.TabIndex = 9;
            this.flightsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // daysTB
            // 
            this.daysTB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysTB.Location = new System.Drawing.Point(351, 12);
            this.daysTB.Multiline = true;
            this.daysTB.Name = "daysTB";
            this.daysTB.Size = new System.Drawing.Size(66, 34);
            this.daysTB.TabIndex = 8;
            this.daysTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lodgingCharge
            // 
            this.lodgingCharge.AutoSize = true;
            this.lodgingCharge.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodgingCharge.Location = new System.Drawing.Point(41, 292);
            this.lodgingCharge.Name = "lodgingCharge";
            this.lodgingCharge.Size = new System.Drawing.Size(260, 21);
            this.lodgingCharge.TabIndex = 7;
            this.lodgingCharge.Text = "Lodging Charges / Per Night:";
            // 
            // SemRegFee
            // 
            this.SemRegFee.AutoSize = true;
            this.SemRegFee.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemRegFee.Location = new System.Drawing.Point(41, 255);
            this.SemRegFee.Name = "SemRegFee";
            this.SemRegFee.Size = new System.Drawing.Size(278, 21);
            this.SemRegFee.TabIndex = 6;
            this.SemRegFee.Text = "Seminar Registration Fee Cost:";
            // 
            // taxiFee
            // 
            this.taxiFee.AutoSize = true;
            this.taxiFee.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxiFee.Location = new System.Drawing.Point(41, 218);
            this.taxiFee.Name = "taxiFee";
            this.taxiFee.Size = new System.Drawing.Size(134, 21);
            this.taxiFee.TabIndex = 5;
            this.taxiFee.Text = "Taxi Fee Cost:";
            // 
            // parkFee
            // 
            this.parkFee.AutoSize = true;
            this.parkFee.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkFee.Location = new System.Drawing.Point(41, 181);
            this.parkFee.Name = "parkFee";
            this.parkFee.Size = new System.Drawing.Size(163, 21);
            this.parkFee.TabIndex = 4;
            this.parkFee.Text = "Parking Fee Cost:";
            // 
            // milesDriven
            // 
            this.milesDriven.AutoSize = true;
            this.milesDriven.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesDriven.Location = new System.Drawing.Point(41, 143);
            this.milesDriven.Name = "milesDriven";
            this.milesDriven.Size = new System.Drawing.Size(128, 21);
            this.milesDriven.TabIndex = 3;
            this.milesDriven.Text = "Miles Driven:";
            // 
            // carRental
            // 
            this.carRental.AutoSize = true;
            this.carRental.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carRental.Location = new System.Drawing.Point(41, 106);
            this.carRental.Name = "carRental";
            this.carRental.Size = new System.Drawing.Size(169, 21);
            this.carRental.TabIndex = 2;
            this.carRental.Text = "Car Rental\'s Cost: ";
            // 
            // Flights
            // 
            this.Flights.AutoSize = true;
            this.Flights.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flights.Location = new System.Drawing.Point(41, 69);
            this.Flights.Name = "Flights";
            this.Flights.Size = new System.Drawing.Size(120, 21);
            this.Flights.TabIndex = 1;
            this.Flights.Text = "Flights Cost:";
            // 
            // numDays
            // 
            this.numDays.AutoSize = true;
            this.numDays.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDays.Location = new System.Drawing.Point(20, 17);
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(217, 29);
            this.numDays.TabIndex = 0;
            this.numDays.Text = "Number of days: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.totalBTN);
            this.panel3.Controls.Add(this.totalTB);
            this.panel3.Controls.Add(this.subTotalTB);
            this.panel3.Controls.Add(this.total);
            this.panel3.Controls.Add(this.subTotal);
            this.panel3.Location = new System.Drawing.Point(455, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 354);
            this.panel3.TabIndex = 6;
            // 
            // totalBTN
            // 
            this.totalBTN.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBTN.Location = new System.Drawing.Point(82, 234);
            this.totalBTN.Name = "totalBTN";
            this.totalBTN.Size = new System.Drawing.Size(155, 111);
            this.totalBTN.TabIndex = 12;
            this.totalBTN.Text = "Total";
            this.totalBTN.UseVisualStyleBackColor = true;
            this.totalBTN.Click += new System.EventHandler(this.totalBTN_Click);
            // 
            // totalTB
            // 
            this.totalTB.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTB.Location = new System.Drawing.Point(179, 143);
            this.totalTB.Multiline = true;
            this.totalTB.Name = "totalTB";
            this.totalTB.Size = new System.Drawing.Size(127, 34);
            this.totalTB.TabIndex = 11;
            this.totalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subTotalTB
            // 
            this.subTotalTB.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTB.Location = new System.Drawing.Point(179, 54);
            this.subTotalTB.Multiline = true;
            this.subTotalTB.Name = "subTotalTB";
            this.subTotalTB.Size = new System.Drawing.Size(127, 34);
            this.subTotalTB.TabIndex = 9;
            this.subTotalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(30, 148);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(83, 29);
            this.total.TabIndex = 2;
            this.total.Text = "Total:";
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(17, 59);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(119, 29);
            this.subTotal.TabIndex = 0;
            this.subTotal.Text = "Subtotal:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(636, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 100);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 542);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pane);
            this.Name = "Form1";
            this.Text = "Travel Expenses";
            this.pane.ResumeLayout(false);
            this.pane.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pane;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label numDays;
        private System.Windows.Forms.Label taxiFee;
        private System.Windows.Forms.Label parkFee;
        private System.Windows.Forms.Label milesDriven;
        private System.Windows.Forms.Label carRental;
        private System.Windows.Forms.Label Flights;
        private System.Windows.Forms.Label lodgingCharge;
        private System.Windows.Forms.Label SemRegFee;
        private System.Windows.Forms.TextBox flightsTB;
        private System.Windows.Forms.TextBox daysTB;
        private System.Windows.Forms.TextBox lodgingTB;
        private System.Windows.Forms.TextBox semRegFeeTB;
        private System.Windows.Forms.TextBox taxiFeeTB;
        private System.Windows.Forms.TextBox parkFeeTB;
        private System.Windows.Forms.TextBox milesTB;
        private System.Windows.Forms.TextBox carRentalTB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label receipt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.TextBox subTotalTB;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button totalBTN;
        private System.Windows.Forms.TextBox receiptTB;
    }
}

