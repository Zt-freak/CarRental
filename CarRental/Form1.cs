using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form1 : Form
    {
        private List<RentalVehicle> rentalVehicles = new List<RentalVehicle>();
        public Form1()
        {
            InitializeComponent();
            this.VehicleTypeSelect.Items.Add("car");
            this.VehicleTypeSelect.Items.Add("van");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (this.VehicleTypeSelect.SelectedItem != null)
            {
                RentalVehicle newVehicle = new RentalVehicle(
                    this.VehicleTypeSelect.SelectedItem.ToString(),
                    Decimal.ToDouble(this.DistanceInput.Value),
                    Decimal.ToDouble(this.FuelInput.Value),
                    this.StartDateInput.Value.Date,
                    this.EndDateInput.Value.Date
                );

                this.rentalVehicles.Add(newVehicle);
                this.VehicleOverview.Rows.Add(
                        newVehicle.type,
                        newVehicle.rentalStart.ToString("yyyy-MM-dd"),
                        newVehicle.rentalEnd.ToString("yyyy-MM-dd")
                    );
                CalculateCosts();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (this.rentalVehicles.Count > 0)
            {
                int index = this.VehicleOverview.CurrentCell.RowIndex;

                this.rentalVehicles.RemoveAt(index);
                this.VehicleOverview.Rows.RemoveAt(index);
                CalculateCosts();
            }
        }

        private void CalculateCosts()
        {
            this.CostOverview.Rows.Clear();

            int vehicleCount = 0;
            double total = 0;
            foreach (RentalVehicle vehicle in this.rentalVehicles)
            {
                vehicleCount++;
                this.CostOverview.Rows.Add(
                    "Vehicle " + vehicleCount + " type",
                    vehicle.type
                    );

                double kmPrice = 0;
                double dayTariff = 0;
                switch (vehicle.type)
                {
                    case "car":
                        kmPrice = 0.2;
                        dayTariff = 50;
                        break;
                    case "van":
                        kmPrice = 0.3;
                        dayTariff = 95;
                        break;
                }

                TimeSpan rentalPeriod = vehicle.rentalEnd - vehicle.rentalStart;

                double travelCost;
                if (rentalPeriod.TotalDays * 100 <= vehicle.distanceTravelled)
                {
                    travelCost = vehicle.distanceTravelled * kmPrice - rentalPeriod.TotalDays * 100;
                }
                else
                {
                    travelCost = 0;
                }
                this.CostOverview.Rows.Add(
                    "Vehicle " + vehicleCount + " travel costs",
                    "\u20AC" + string.Format("{0:f2}", Math.Round(travelCost, 2))
                    );

                double dayCosts = dayTariff * rentalPeriod.TotalDays;
                this.CostOverview.Rows.Add(
                    "Vehicle " + vehicleCount + " total day tariffs",
                    "\u20AC" + string.Format("{0:f2}", Math.Round(dayCosts, 2))
                    );

                this.CostOverview.Rows.Add(
                    "Vehicle " + vehicleCount + " total costs",
                    "\u20AC" + string.Format("{0:f2}", Math.Round(dayCosts + travelCost, 2))
                    );

                this.CostOverview.Rows.Add(
                    "Vehicle " + vehicleCount + " fuel costs",
                    "\u20AC" + string.Format("{0:f2}", Math.Round(vehicle.fuelExpenses, 2))
                    );

                total += dayCosts + travelCost + vehicle.fuelExpenses;
            }

            this.CostOverview.Rows.Add(
                    "Total costs",
                    "\u20AC" + string.Format("{0:f2}", Math.Round(total, 2))
                    );
        }
    }

    public class RentalVehicle
    {
        public string type;
        public double distanceTravelled;
        public double fuelExpenses;
        public DateTime rentalStart;
        public DateTime rentalEnd;
        public RentalVehicle (string type, double distanceTravelled, double fuelExpenses, DateTime rentalStart, DateTime rentalEnd)
        {
            this.type = type;
            this.distanceTravelled = distanceTravelled;
            this.fuelExpenses = fuelExpenses;
            this.rentalStart = rentalStart;
            this.rentalEnd = rentalEnd;
        }
    }
}
