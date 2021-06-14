using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class delVehicle : Form
    {
        public int ID;
        public delVehicle()
        {
            
            InitializeComponent();
            VehicleinfodatagridView.CellClick += VehicleinfodatagridView_CellClick;
        }

        private void VehicleinfodatagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VehicleinfodatagridView.CurrentRow.Selected = true;
            currentBranchTB.Text = VehicleinfodatagridView.Rows[e.RowIndex].Cells["currentBranchID"].Value.ToString();
            vehicleTypeTextBox.Text = VehicleinfodatagridView.Rows[e.RowIndex].Cells["Vtype"].Value.ToString();
            makeTextBox.Text = VehicleinfodatagridView.Rows[e.RowIndex].Cells["make"].Value.ToString();
            modelTextBox.Text = VehicleinfodatagridView.Rows[e.RowIndex].Cells["model"].Value.ToString();
            seatsTextBox.Text = VehicleinfodatagridView.Rows[e.RowIndex].Cells["seats"].Value.ToString();
            milesTextBox.Text = VehicleinfodatagridView.Rows[e.RowIndex].Cells["miles"].Value.ToString();
            makeYearTextBox.Text = VehicleinfodatagridView.Rows[e.RowIndex].Cells["makeYear"].Value.ToString();
            availabilityTextBox.Text = VehicleinfodatagridView.Rows[e.RowIndex].Cells["vehicleAvailability"].Value.ToString();
            

            ID =(int) VehicleinfodatagridView.Rows[e.RowIndex].Cells["VehicleID"].Value;
            
        }
        private void populateDGV()
        {
            String query = $"SELECT * FROM Vehicle;";
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            General.validTextboxEntry(label9, query, VehicleinfodatagridView);

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentBranchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            String branchName = currentBranchTB.Text.TrimEnd();
            String Vtype = vehicleTypeTextBox.Text.TrimEnd();
            String make = makeTextBox.Text.TrimEnd();
            String model = modelTextBox.Text.TrimEnd();
            String seats = seatsTextBox.Text.TrimEnd();
            String miles = milesTextBox.Text.TrimEnd();
            String makeYear = makeYearTextBox.Text.TrimEnd();
            String availability = availabilityTextBox.Text.TrimEnd();

            if (make == "" | model == "" | seats == "" | miles == "" | makeYear == "" | branchName == "" | Vtype == "" | availability == "")
            {
                label9.Text = "All Fields are required!";
                label9.ForeColor = Color.FromArgb(192, 0, 0);
            }

            else
            {
                deleteVehicle( );
               // Bind_Data();
                queryResultlabel.Text = "deleted successfully to the database!";
                queryResultlabel.ForeColor = Color.FromArgb(0, 192, 0);
                populateDGV();

            }
        }



        public void deleteVehicle()
        {



            try
            {
                using (SqlConnection connection = new SqlConnection("server=DESKTOP-FN58B5T;" +
                                        "Trusted_Connection=yes;" +
                                        "database=car-rental-agency; " +
                                        "connection timeout=30"))
                {
                    connection.Open();
                    String vehicleType = vehicleTypeTextBox.Text;

                    using (SqlCommand command = new SqlCommand("DELETE FROM  Vehicle  WHERE  VehicleID  = '" + ID + "'", connection))
                    {
                        
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    //using (SqlCommand command = new SqlCommand("DELETE FROM  Bookings  WHERE  VehicleID  = '" + ID + "'", connection))
                    //{
                    //    command.ExecuteNonQuery();
                   // connection.Close();
                    //}



                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Sorry Cannot delete");
            }

        }


        public static void fillComboBox(ComboBox cb, string colName, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string val = table.Rows[i][colName].ToString();
                cb.Items.Add(val);
            }
        }

        private void UpdateVehicle_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void VehicleinfodatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}