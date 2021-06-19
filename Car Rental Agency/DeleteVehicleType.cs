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
    public partial class DeleteVehicleType : Form
    {
        public DeleteVehicleType()
        {
            InitializeComponent();
            string branchQuery = "SELECT Vtype FROM VehicleType;";
            DataTable branchTable = Database.getDataTableAfterRunningQuery(branchQuery);
            fillComboBox(vehicleTypeComboBox, "Vtype", branchTable);
        }

        public static void fillComboBox(ComboBox cb, string colName, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string val = table.Rows[i][colName].ToString();
                cb.Items.Add(val);
            }
        }

        private void updateVtype_Click(object sender, EventArgs e)
        {
            
        }
        void Bind_Data()
        {
            String query = $"SELECT * FROM VehicleType;";
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            General.validTextboxEntry(queryResultlabel, query, VehicleTypeDataGridView);

        }

        private void vehicleTypeSearchBtm_Click(object sender, EventArgs e)
        {
            queryResultlabel.Visible = true;
            if (vehicleTypeComboBox.SelectedIndex == -1)
            {
                queryResultlabel.Text = "Uh oh! Cannot Find the Branch Name";
                queryResultlabel.ForeColor = Color.FromArgb(0, 192, 0);
            }

            else
            {
                string Vtype = vehicleTypeComboBox.SelectedItem.ToString();

                String query = $"SELECT * FROM VehicleType WHERE Vtype = '{Vtype}';";
                DataTable table = Database.getDataTableAfterRunningQuery(query);
                General.validTextboxEntry(queryResultlabel, query, VehicleTypeDataGridView);
            }
        }

        private void VehicleTypeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VehicleTypeDataGridView.CurrentRow.Selected = true;
            vehicleTypeTextBox.Text = VehicleTypeDataGridView.Rows[e.RowIndex].Cells["Vtype"].Value.ToString();
            DailyFee.Text = VehicleTypeDataGridView.Rows[e.RowIndex].Cells["dailyRate"].Value.ToString();
            WeeklyFeeTextBox.Text = VehicleTypeDataGridView.Rows[e.RowIndex].Cells["weeklyRate"].Value.ToString();
            MonthlyFee.Text = VehicleTypeDataGridView.Rows[e.RowIndex].Cells["monthlyRate"].Value.ToString();
            lateFeeTextBox.Text = VehicleTypeDataGridView.Rows[e.RowIndex].Cells["latefee"].Value.ToString();
            cBranchFeeTextBox.Text = VehicleTypeDataGridView.Rows[e.RowIndex].Cells["changeBranchFee"].Value.ToString();
        }

        private void DeleteVehicleType_Load(object sender, EventArgs e)
        {
            Bind_Data();
        }

        public void deleteVtype()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection("server=SYNAPSE;" +
                                        "Trusted_Connection=yes;" +
                                        "database=car-rental-agency; " +
                                        "connection timeout=30"))
                {
                    connection.Open();
                    String vehicleType = vehicleTypeTextBox.Text;

                    using (SqlCommand command = new SqlCommand("DELETE FROM  Vehicle  WHERE  Vtype  = '" + vehicleType + "'", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand("DELETE FROM  VehicleType  WHERE  Vtype  = '" + vehicleType + "'", connection))
                    {
                        command.ExecuteNonQuery();
                    }


                    connection.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Sorry Cannot delete");
            }

        }

        private void updateVtype_Click_1(object sender, EventArgs e)
        {
            queryResultlabel.Visible = true;
            String vehicleType = vehicleTypeTextBox.Text;
            String dailyFee = DailyFee.Text;
            String weekyFee = WeeklyFeeTextBox.Text;
            String monthlyFee = MonthlyFee.Text;
            String lateFee = lateFeeTextBox.Text;
            String changeBranchFee = cBranchFeeTextBox.Text;

            // Ensure all the fields are not left empty

            if (vehicleType == "" | dailyFee == "" | monthlyFee == "" | weekyFee == "" | lateFee == "" | changeBranchFee == "")
            {
                queryResultlabel.Text = "All Fields are required";
                queryResultlabel.ForeColor = Color.FromArgb(192, 0, 0);
            }
            else
            {
                deleteVtype();
                Bind_Data();
                queryResultlabel.Text = "deleted successfully to the database!";
                queryResultlabel.ForeColor = Color.FromArgb(0, 192, 0);
            }

            //vehicleTypeTextBox.Text = "";
            //DailyFee.Text = "";
            //WeeklyFeeTextBox.Text = "";
            //MonthlyFee.Text = "";
            //lateFeeTextBox.Text = "";
            //cBranchFeeTextBox.Text = "";

        }
    }
}
