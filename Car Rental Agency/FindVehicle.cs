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
    public partial class FindVehicle : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public FindVehicle()
        {
            InitializeComponent();
            con = new SqlConnection("server=SYNAPSE;" +
                                           "Trusted_Connection=yes;" +
                                           "database=car-rental-agency; " +
                                           "connection timeout=30");
            cmd = new SqlCommand();
            con.Open();

            // Finding a Vehicle By different attriubutes
            vehicleIDSearchBtn.Click += VehicleIDSearchBtn_Click;
            vehicleTypeSearchBtn.Click += VehicleTypeSearchBtn_Click;
            findVehicleDataGridView.CellValueChanged += FindVehicleDataGridView_CellValueChanged;
            findVehicleDataGridView.EditingControlShowing += FindVehicleDataGridView_EditingControlShowing;

            // Vehicle Type
            String vtypeQuery = $"SELECT DISTINCT Vtype from VehicleType";
            DataTable vTypeTable = Database.getDataTableAfterRunningQuery(vtypeQuery);
            fillComboBox(VtypeComboBox, "Vtype", vTypeTable);

            // Seats
            String seatsQuery = $"SELECT DISTINCT seats from Vehicle";
            DataTable seatsTable = Database.getDataTableAfterRunningQuery(seatsQuery);
            fillComboBox(seatsComboBox, "seats", seatsTable);

            // Miles
            String milesQuery = $"SELECT DISTINCT miles from Vehicle";
            DataTable milesTable = Database.getDataTableAfterRunningQuery(milesQuery);
            fillComboBox(vehicleMilesComboBox, "miles", milesTable);

            // Branch
            string branchQuery = "SELECT branchName FROM Branch;";
            DataTable branchTable = Database.getDataTableAfterRunningQuery(branchQuery);
            fillComboBox(brNameComboBox, "branchName", branchTable);
        }
        public static void fillComboBox(ComboBox cb, string colName, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string val = table.Rows[i][colName].ToString();
                cb.Items.Add(val);
            }
        }

        private void FindVehicleDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colIndex = findVehicleDataGridView.CurrentCell.ColumnIndex;
            // When column is Branch_ID, Year or Capacity
            if (colIndex == 4 || colIndex == 5 | colIndex == 6 | colIndex == 7)
            {
                e.Control.KeyPress += numericTextBox_KeyPress;
            }
            // When it is any other column other than the numeric columns
            else
            {
                e.Control.KeyPress -= numericTextBox_KeyPress;
            }
        }

        private void FindVehicleDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (findVehicleDataGridView != null) 
            {
                DataGridViewRow row = findVehicleDataGridView.CurrentRow; ;

                int currentColIndex = findVehicleDataGridView.CurrentCell.ColumnIndex;
                var update = findVehicleDataGridView.CurrentCell.Value;

                string query;
                string queryTable = "Vehicle";
                String keyName = "VehicleID";

                var ID = row.Cells[keyName].Value;

                switch (currentColIndex)
                {
                    case 1:  //Branch ID
                        query = $"UPDATE {queryTable} SET currentBranchID = {update} WHERE {keyName} = {ID};";
                        break;
                    case 2: // Vtype
                        query = $"UPDATE {queryTable} SET Vtype = {update} WHERE {keyName} = {ID};";
                        break;
                    case 3: //make
                        query = $"UPDATE {queryTable} SET make = {update} WHERE {keyName} = {ID};";
                        break;
                    case 4: //model
                        query = $"UPDATE {queryTable} SET model = {update} WHERE {keyName} = {ID};";
                        break;
                    case 5: //seats
                        query = $"UPDATE {queryTable} SET seats = {update} WHERE {keyName} = {ID};";
                        break;
                    case 6: // miles
                        query = $"UPDATE {queryTable} SET miles = {update} WHERE {keyName} = {ID};";
                        break; 

                    case 7: // makeYear
                        query = $"UPDATE {queryTable} SET makeYear = {update} WHERE {keyName} = {ID};";
                        break;
                    case 8: //vehicle Avilability
                        query = $"UPDATE {queryTable} SET vehicleAvailability = {update} WHERE {keyName} = {ID};";
                        break;
                    default:
                        return;
                }
                Database.runQuery(query);

            }
        }


        private void BranchSearchBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void VehicleTypeSearchBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void MilesSearchBtn_Click(object sender, EventArgs e)
        {
            
        }

        // Finding Vehicle Based on Seats
        private void SeatsSearchBtn_Click(object sender, EventArgs e)
        {
            
        }
            
        // Finding Vehicle Based on VehicleID
        private void VehicleIDSearchBtn_Click(object sender, EventArgs e)
        {
          
        }


        
        /*
         * Allowing only numerical values for the textbox
         */
        private void numericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void vehicleIDSearchBtn_Click_1(object sender, EventArgs e)
        {
            
            ErrorLabel.Visible = true;
            string branchName = brNameComboBox.SelectedItem.ToString();

            if (brNameComboBox.SelectedIndex == -1 | vehicleMilesComboBox.SelectedIndex == -1 | seatsComboBox.SelectedIndex == -1 | VtypeComboBox.SelectedIndex == -1)
            {
                ErrorLabel.Text = "Please Enter the Values for all the fields, fields cannot be Empty";
                ErrorLabel.ForeColor = Color.FromArgb(0, 192, 0);
            }

            else
            {
                
                string query = $"SELECT branchID FROM Branch WHERE branchName = '{branchName}';";
                DataTable table = Database.getDataTableAfterRunningQuery(query);

                var branchID = (table.Rows[0]["branchID"]);


                String vehiclequery = $"SELECT * FROM Vehicle WHERE currentBranchID = '{branchID}' AND seats = '{seatsComboBox.Text}' AND miles = '{vehicleMilesComboBox.Text}' AND Vtype = '{VtypeComboBox.Text}'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(vehiclequery, con);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                findVehicleDataGridView.DataSource = dataTable;
                findVehicleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                findVehicleDataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                
            }
        }

        private void vehicleTypeSearchBtn_Click_1(object sender, EventArgs e)
        {
            ErrorLabel.Visible = true;
            if (textBox1.Text == "")
            {
                ErrorLabel.Text = "Please Enter the Values for VehiclType, fields cannot be Empty";
                ErrorLabel.ForeColor = Color.FromArgb(0, 192, 0);
            }

            else
            {
                String query = $"SELECT * FROM Vehicle WHERE Vtype = '{textBox1.Text.TrimEnd()}'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                findVehicleDataGridView.DataSource = dataTable;
                findVehicleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                findVehicleDataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            }

        }

        private void findVehicleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
