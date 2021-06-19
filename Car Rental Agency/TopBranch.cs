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
    public partial class TopBranch : Form
    {
        public TopBranch()
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
            if (cityTextBox.Text.TrimEnd() == "" && provinceTextBox.Text.TrimEnd() == "" &&
                countryTextBox.Text.TrimEnd() == "")
            {
                errorLabel.Text = "Error: Please search by one parameter";
                return false;
            }
            // Counting the number of empty fields and if there are less than 2 empty fields,
            // the function returns false
            int count = 0;

            if (cityTextBox.Text.TrimEnd() == "") { count++; }
            if (provinceTextBox.Text.TrimEnd() == "") { count++; }
            if (countryTextBox.Text.TrimEnd() == "") { count++; }

            if (count < 2)
            {
                errorLabel.Text = "Error: Please search by only one parameter";
                return false;
            }
            return true;
        }
        /*
         * Returns query for finding all the top branches based on number of successful transactions and the parameters entered by the user
         */
        private string getTextBoxQuery(string searchParameter)
        {
            return
            "select Branch.branchID, Branch.branchName, temp.TransactionCount, Branch.street, Branch.city, Branch.state, Branch.country" +
            " from Branch, " +
                    "(select Branch.branchID, count(*) as 'TransactionCount' " +
                    "from [Booking], Branch " +
                    "where [Booking].PickUpBranchID = Branch.branchID and[Booking].Status = 'Success' " +
                            $"and {searchParameter} " +
                    "group by Branch.branchID) as temp " +
            "where Branch.branchID = temp.branchID " +
            "order by temp.TransactionCount DESC;";
        }
        /*
         * When the admin searches for the most popular branch for a specific:
         * - City
         * - Province
         * - Country
         * The search only takes place by one text field. The function reports an error if the user 
         * enters in more than one text field.
         */
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void popularBranchesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchSpecificButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = true; // Making the error label for specific search visible
            string query;

            if (!errorCheckSpecificFields()) // Error checking for invalid number of input entries
            {
               errorLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
                return;
            }

            if (cityTextBox.Text.TrimEnd() != "")
            {
                // query by city name
                // Finding all the transaction counts for the cities with the given name.
                query = getTextBoxQuery($"Branch.city = '{cityTextBox.Text.TrimEnd()}'");
            }
            else if (provinceTextBox.Text.TrimEnd() != "")
            {
                // query by province name
                // Finding all the transaction counts for the provinces with the given name.
                query = getTextBoxQuery($"Branch.state = '{provinceTextBox.Text.TrimEnd()}'");
            }
            else if (countryTextBox.Text.TrimEnd() != "")
            {
                // query by country name
                // Finding all the transaction counts for the country with the given name.
                query = getTextBoxQuery($"Branch.country = '{countryTextBox.Text.TrimEnd()}'");
            }
            else { return; }
            // Run query and update the table
            General.validTextboxEntry(errorLabel, query, popularBranchesDataGridView);
        }
    }
}
