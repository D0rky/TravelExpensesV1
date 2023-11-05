using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelExpenses_AdamMartinezJr;

namespace travelExpenses_AdamMartinezJr
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit!", "Travel Expense V1",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            daysTB.Clear();
            flightsTB.Clear();
            carRentalTB.Clear();
            milesTB.Clear();
            parkFeeTB.Clear();
            taxiFeeTB.Clear();
            semRegFeeTB.Clear();
            lodgingTB.Clear();
            subTotalTB.Clear();
            totalTB.Clear();
            receiptTB.Clear();
        }

        private void totalBTN_Click(object sender, EventArgs e)
        {
            // Retrieve user inputs from TextBoxes
            if (int.TryParse(daysTB.Text, out int days) &&
                decimal.TryParse(flightsTB.Text, out decimal airfare) &&
                decimal.TryParse(carRentalTB.Text, out decimal carRental) &&
                int.TryParse(milesTB.Text, out int miles) &&
                decimal.TryParse(parkFeeTB.Text, out decimal parking) &&
                decimal.TryParse(taxiFeeTB.Text, out decimal taxi) &&
                decimal.TryParse(semRegFeeTB.Text, out decimal seminarFees) &&
                decimal.TryParse(lodgingTB.Text, out decimal lodgingPerNight))
            {
                // Create an instance of travelExpensesCal
                travelExpensesCal travelExpensesCalculator = new travelExpensesCal(days, airfare, carRental, miles, parking, taxi, seminarFees, lodgingPerNight);

                // Calculate total expenses
                decimal totalExpenses = travelExpensesCalculator.CalculateTotalExpenses();

                // Calculate total allowable expenses
                decimal totalAllowableExpenses = travelExpensesCalculator.CalculateTotalAllowableExpenses();

                // Calculate excess (if any) and amount saved
                decimal excess = totalExpenses - totalAllowableExpenses;
                decimal amountSaved = (excess >= 0) ? excess : 0; // If expenses were under the total allowed, set amountSaved to 0

                // Calculate tax as the amount that exceeds allowable expenses
                decimal tax = (excess >= 0) ? 0 : -excess;

                // Create a formatted string with the information
                string receiptText = $"Airfare: {airfare:C}\r\n";
                receiptText += $"Car Rental: {carRental:C}\r\n";
                receiptText += $"Miles Driven: {miles}\r\n";
                receiptText += $"Parking Fees: {Math.Min(parking * days, 10):C} (up to $10.00)\r\n";
                receiptText += $"Taxi Charges: {Math.Min(taxi * days, 20):C} (up to $20.00)\r\n";
                receiptText += $"Seminar Fees: {seminarFees:C}\r\n";
                receiptText += $"Lodging Charges per Night: {Math.Min(lodgingPerNight * days, 95):C} (up to $95.00)\r\n";
                receiptText += $"Total Expenses: {totalExpenses:C}\r\n";
                receiptText += $"Total Allowable Expenses: {totalAllowableExpenses:C}\r\n";
                receiptText += $"Excess: {excess:C}\r\n";
                receiptText += $"Amount Saved: {amountSaved:C}\r\n";

                // Set the formatted string as the Text property of receiptTB
                receiptTB.Text = receiptText;
                totalTB.Text = totalExpenses.ToString("c"); // Display as currency
                subTotalTB.Text = totalAllowableExpenses.ToString("c");
            }
            else
            {
                // Handle invalid input, e.g., display an error message or log the issue.
                MessageBox.Show("Invalid input. Please enter valid numeric values.");
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(receiptTB.Text);
                    }

                    MessageBox.Show("Receipt exported successfully!", "Export Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while exporting the receipt: " + ex.Message, "Export Receipt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
