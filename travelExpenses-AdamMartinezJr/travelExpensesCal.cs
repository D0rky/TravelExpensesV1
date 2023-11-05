using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelExpenses_AdamMartinezJr
{
    class travelExpensesCal
    {
        private int numberOfDays;
        private decimal airfare;
        private decimal carRentalFees;
        private int milesDriven;
        private decimal parkingFees;
        private decimal taxiCharges;
        private decimal seminarFees;
        private decimal lodgingChargesPerNight;

        public travelExpensesCal(
            int days, decimal airfare, decimal carRental, int miles,
            decimal parking, decimal taxi, decimal seminarFees, decimal lodgingPerNight)
        {
            numberOfDays = days;
            this.airfare = airfare;
            carRentalFees = carRental;
            milesDriven = miles;
            parkingFees = parking;
            taxiCharges = taxi;
            this.seminarFees = seminarFees;
            lodgingChargesPerNight = lodgingPerNight;
        }

        public decimal CalculateTotalExpenses()
        {
            // Calculate the expenses based on the provided policy
            decimal mealsExpenses = 37 * numberOfDays;
            decimal parkingExpenses = Math.Min(parkingFees, 10) * numberOfDays;
            decimal taxiExpenses = Math.Min(taxiCharges, 20) * numberOfDays;
            decimal lodgingExpenses = Math.Min(lodgingChargesPerNight, 95) * numberOfDays;
            decimal mileageExpenses = 0.27m * milesDriven;

            // Calculate total expenses incurred by the businessperson
            decimal totalExpenses = airfare + carRentalFees + parkingExpenses + taxiExpenses + seminarFees + lodgingExpenses + mileageExpenses + mealsExpenses;

            return totalExpenses;
        }

        public decimal CalculateTotalAllowableExpenses()
        {
            decimal mealsExpenses = 37 * numberOfDays;
            decimal parkingExpenses = Math.Min(parkingFees, 10 * numberOfDays); // Up to $10.00 per day
            decimal taxiExpenses = Math.Min(taxiCharges, 20 * numberOfDays); // Up to $20.00 per day
            decimal lodgingExpenses = Math.Min(lodgingChargesPerNight * numberOfDays, 95 * numberOfDays); // Up to $95.00 per day
            decimal mileageExpenses = 0.27m * milesDriven;

            return mealsExpenses + parkingExpenses + taxiExpenses + lodgingExpenses + mileageExpenses;
        }


    }
}
