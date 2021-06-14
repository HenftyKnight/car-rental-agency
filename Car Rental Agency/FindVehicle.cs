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
    public partial class FindVehicle : Form
    {
        public FindVehicle()
        {
            InitializeComponent();
            // Finding a Vehicle By different attriubutes
            vehicleIDSearchBtn.Click += VehicleIDSearchBtn_Click;
            seatsSearchBtn.Click += SeatsSearchBtn_Click;
            milesSearchBtn.Click += MilesSearchBtn_Click;
            vehicleTypeSearchBtn.Click += VehicleTypeSearchBtn_Click;
            branchSearchBtn.Click += BranchSearchBtn_Click;
            findVehicleDataGridView.CellValueChanged += FindVehicleDataGridView_CellValueChanged;
            findVehicleDataGridView.EditingControlShowing += FindVehicleDataGridView_EditingControlShowing;
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
            genQuerylabel.Visible = true;

            String branch = BranchTextBox.Text.TrimEnd();
            if (branch == "")
            {
                genQuerylabel.Text = "Uh oh! Branch cannot be empty!";
                genQuerylabel.ForeColor = Color.FromArgb(0, 192, 0);
            }

            else
            {
                genQuerylabel.Text = "Vehicles with given Branch found!";
                genQuerylabel.ForeColor = Color.FromArgb(0, 192, 0);

                String query = $"SELECT * FROM Vehicle,Branch WHERE Vehicle.currentBranchID = Branch.branchID AND Branch.branchName = '{branch}';";
                General.validTextboxEntry(genQuerylabel, query, findVehicleDataGridView);
            }
        }

        private void VehicleTypeSearchBtn_Click(object sender, EventArgs e)
        {
            genQuerylabel.Visible = true;

            String vehicleType = vehicleTypeTextBox.Text.TrimEnd();
            if (vehicleType == "")
            {
                genQuerylabel.Text = "Uh oh! Vehicle Type cannot be empty!";
                genQuerylabel.ForeColor = Color.FromArgb(0, 192, 0);
            }

            else
            {
                genQuerylabel.Text = "Vehicle with given Type found!";
                genQuerylabel.ForeColor = Color.FromArgb(0, 192, 0);

                String query = $"SELECT * FROM Vehicle WHERE Vehicle.Vtype = '{vehicleType}';";
                General.validTextboxEntry(genQuerylabel, query, findVehicleDataGridView);
            }
        }

        private void MilesSearchBtn_Click(object sender, EventArgs e)
        {
            genQuerylabel.Visible = true;

            String miles = milesTextBox.Text.TrimEnd();
            if (miles == "")
            {
                genQuerylabel.Text = "Uh oh! Miles cannot be empty!";
                genQuerylabel.ForeColor = Color.FromArgb(0, 192, 0);
            }

            else
            {
                genQuerylabel.Text = "Vehicle with given Miles found!";
                genQuerylabel.ForeColor = Color.FromArgb(0, 192, 0);

                String query = $"SELECT * FROM Vehicle WHERE miles = '{miles}';";
                General.validTextboxEntry(genQuerylabel, query, findVehicleDataGridView);
            }
        }

        // Finding Vehicle Based on Seats
        private void SeatsSearchBtn_Click(object sender, EventArgs e)
        {
            genQuerylabel.Visible = true;

            String seats = seatsTextBox.Text.TrimEnd();
            if (seats == "")
            {
                genQuerylabel.Text = "Uh oh! Seats cannot be empty!";
                genQuerylabel.ForeColor = Color.FromArgb(0, 192, 0);
            }

            else
            {
                genQuerylabel.Text = "Vehicle with given Seats found!";
                genQuerylabel.ForeColor = Color.FromArgb(0, 192, 0);

                String query = $"SELECT * FROM Vehicle WHERE seats = '{seats}';";
                General.validTextboxEntry(genQuerylabel, query, findVehicleDataGridView);
            }
        }
            
        // Finding Vehicle Based on VehicleID
        private void VehicleIDSearchBtn_Click(object sender, EventArgs e)
        {
            genQuerylabel.Visible = true;

            String vehicleID = vehicleIDTextBox.Text.TrimEnd();
            if (vehicleID == "")
            {
                genQuerylabel.Text = "Uh oh! VehicleID cannot be empty!";
                genQuerylabel.ForeColor = Color.FromArgb(0, 192, 0);
            }

            else
            {
                genQuerylabel.Text = "Vehicle with given VehicleID found!";
                genQuerylabel.ForeColor = Color.FromArgb(0, 192, 0);

                String query = $"SELECT * FROM Vehicle WHERE VehicleID = '{vehicleID}';";
                General.validTextboxEntry(genQuerylabel, query, findVehicleDataGridView);
            }
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
            Update_confirm login = new Update_confirm();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FindVehicle_Load(object sender, EventArgs e)
        {

        }
    }
}
