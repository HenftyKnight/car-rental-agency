using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Agency
{
    public partial class TopVehicle : Form
    {
        public TopVehicle()
        {
            InitializeComponent();
        }

        /*
        * Error checks for the number of entries entered by the user. 
        * If the user enters in only one text field, then the function returns true
        * If the user enters nothing, the function returns false.
        * If the user enters in more than one text field the function returns false.
        */
        private bool errorCheckSpecificFields()
        {
            // If all fields are empty
            if (branchTextBox.Text.TrimEnd() == "" && cityTextBox.Text.TrimEnd() == "" &&
                    stateTextBox.Text.TrimEnd() == "" && countryTextBox.Text.TrimEnd() == "")
            {
                specificSearchErrorLabel.Text = "Error: Please search by one parameter";
                specificSearchErrorLabel.Visible = true;
                return false;
            }
            // Counting the number of empty fields and if there are less than 3 empty fields,
            // the function returns false
            int count = 0;

            if (branchTextBox.Text.TrimEnd() == "") { count++; }
            if (cityTextBox.Text.TrimEnd() == "") { count++; }
            if (stateTextBox.Text.TrimEnd() == "") { count++; }
            if (countryTextBox.Text.TrimEnd() == "") { count++; }

            if (count < 3)
            {
                specificSearchErrorLabel.Text = "Error: Please search by only one parameter";
                specificSearchErrorLabel.Visible = true;
                return false;
            }
            return true;
        }
        /*
         * Returns a query for searching the most popular cars based on the number of transactions
         */
        private string getTextBoxQuery(string parameter)
        {
            return
            "select Vehicle.vehicleID, model, make, TransactionCount " +
            "from Vehicle, " +
                "(select Vehicle.vehicleID, count(*) as 'TransactionCount' " +
                "from[Booking], Branch, Vehicle " +
                "where[Booking].PickUpBranchID = Branch.branchID " +
                    "and[Booking].VehicleID = Vehicle.vehicleID " +
                    "and[Booking].Status = 'Success' " +
                    $"and {parameter} " +
                    "group by Vehicle.vehicleID) as temp " +
            "where Vehicle.vehicleID = temp.vehicleID " +
            "order by TransactionCount DESC";
        }

        /*
         * When the admin searches for the most popular car for a specific:
         * - Branch
         * - City
         * - Province
         * - Country
         * The search only takes place by one text field. The function reports an error if the user 
         * enters in more than one text field.
         */
        private void searchSpecificButton_Click(object sender, EventArgs e)
        {
            specificSearchErrorLabel.Visible = true; // Making the error label for specific search invisible
            string query;

            if (!errorCheckSpecificFields()) // Error checking for invalid number of input entries
            {
                specificSearchErrorLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
                return;
            }

            if (branchTextBox.Text.TrimEnd() != "")
            {
                // query by the branch name
                query = getTextBoxQuery($"Branch.Name = '{branchTextBox.Text.TrimEnd()}'");
            }
            else if (cityTextBox.Text.TrimEnd() != "")
            {
                // query by city name
                query = getTextBoxQuery($"Branch.City = '{cityTextBox.Text.TrimEnd()}'");
            }
            else if (stateTextBox.Text.TrimEnd() != "")
            {
                // query by province name
                query = getTextBoxQuery($"Branch.Province = '{stateTextBox.Text.TrimEnd()}'");
            }
            else if (countryTextBox.Text.TrimEnd() != "")
            {
                // query by country name
                query = getTextBoxQuery($"Branch.Country = '{countryTextBox.Text.TrimEnd()}'");
            }
            else { return; }
            // Run query and update the table
            General.validTextboxEntry(specificSearchErrorLabel, query, popularCarDataGridView);
        }

        private void searchSpecificButton_Click_1(object sender, EventArgs e)
        {
            specificSearchErrorLabel.Visible = true; // Making the error label for specific search invisible
            string query;

            if (!errorCheckSpecificFields()) // Error checking for invalid number of input entries
            {
                specificSearchErrorLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
                return;
            }

            if (branchTextBox.Text.TrimEnd() != "")
            {
                // query by the branch name
                query = getTextBoxQuery($"Branch.branchName = '{branchTextBox.Text.TrimEnd()}'");
            }
            else if (cityTextBox.Text.TrimEnd() != "")
            {
                // query by city name
                query = getTextBoxQuery($"Branch.city = '{cityTextBox.Text.TrimEnd()}'");
            }
            else if (stateTextBox.Text.TrimEnd() != "")
            {
                // query by province name
                query = getTextBoxQuery($"Branch.state = '{stateTextBox.Text.TrimEnd()}'");
            }
            else if (countryTextBox.Text.TrimEnd() != "")
            {
                // query by country name
                query = getTextBoxQuery($"Branch.country = '{countryTextBox.Text.TrimEnd()}'");
            }
            else { return; }
            // Run query and update the table
            General.validTextboxEntry(specificSearchErrorLabel, query, popularCarDataGridView);
        }
    }
}
