using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Car_Rental_Agency
{
    public partial class AddNewVehicle : Form
    {
        SqlConnection mysqlConnection;
        SqlCommand mysqlCommand;
        public AddNewVehicle(SqlConnection mysqlConnection2)
        {
            InitializeComponent();
            addVehicleBtn.Click += AddVehicleBtn_Click; ;
            mysqlConnection = mysqlConnection2;

            mysqlCommand = new SqlCommand();
            mysqlCommand.Connection = mysqlConnection;

            mysqlCommand.CommandText = "SELECT branchName FROM Branch";
            
            string branchQuery = "SELECT branchName FROM Branch;";
            DataTable branchTable = Database.getDataTableAfterRunningQuery(branchQuery);
            fillComboBox(branchNameCombobox, "branchName", branchTable);

            string VehicleTypeQuery = "SELECT Vtype FROM VehicleType;";
            DataTable VehicleTypeTable = Database.getDataTableAfterRunningQuery(VehicleTypeQuery);
            fillComboBox(vehicleTypeComboBox, "Vtype", VehicleTypeTable);
        }
        

        private void AddVehicleBtn_Click(object sender, EventArgs e)
        {
            queryResult.Visible = true;
            String make  = makeTextBox.Text.TrimEnd();
            String model = modelTextBox.Text.TrimEnd();
            String seats = seatsTextBox.Text.TrimEnd();
            String miles = milesTextBox.Text.TrimEnd();
            String makeYear = yearTextBox.Text.TrimEnd();

            if (make == "" | model == "" | seats == "" | miles == "" | makeYear == "" | availabilityComboBox.SelectedIndex == -1 | branchNameCombobox.SelectedIndex == -1 | vehicleTypeComboBox.SelectedIndex == -1)
            {
                queryResult.Text = "All Fields are required!";
                queryResult.ForeColor = Color.FromArgb(192, 0, 0);
            }

            else 
            {
                queryResult.Text = "Vehicle SuccessFully Added to the Database!";
                queryResult.ForeColor = Color.FromArgb(0,192, 0);

                string branchName = branchNameCombobox.SelectedItem.ToString();
                string vehicleType = vehicleTypeComboBox.SelectedItem.ToString();
                string availability = availabilityComboBox.SelectedItem.ToString();

                // Find BranchID from the given BranchName in the dropDown
                string query = $"SELECT branchID FROM Branch WHERE branchName = '{branchName}';";
                DataTable table = Database.getDataTableAfterRunningQuery(query);

                var branchID = (table.Rows[0]["branchID"]);

                // Query
                query = "INSERT INTO Vehicle(currentBranchID, Vtype, make, model, seats, miles, makeYear, vehicleAvailability)" +
                        $"VALUES('{branchID}','{vehicleType}','{make}','{model}','{seats}','{miles}','{makeYear}','{availability}')";

                Database.runQuery(query);
            }
            makeTextBox.Text = "";
            modelTextBox.Text = "";
            seatsTextBox.Text = "";
            milesTextBox.Text = "";
            yearTextBox.Text = "";




        }


        private void add_car_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public static void fillComboBox(ComboBox cb, string colName, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string val = table.Rows[i][colName].ToString();
                cb.Items.Add(val);
            }
        }

        private void vehicleTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void branchNameCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void makeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void modelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void seatsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void milesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void availabilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
