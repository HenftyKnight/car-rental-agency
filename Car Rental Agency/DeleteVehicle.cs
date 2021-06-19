using System;
using System.Collections.Generic;
using System.ComponentModel;
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.ComponentModel;
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Rental_Agency
<<<<<<< HEAD
{
    public partial class DeleteVehicle : Form
    {
        public int ID;
        public DeleteVehicle()
        {
            InitializeComponent();
        }

=======
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
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
        private void populateDGV()
        {
            String query = $"SELECT * FROM Vehicle;";
            DataTable table = Database.getDataTableAfterRunningQuery(query);
<<<<<<< HEAD
            General.validTextboxEntry(queryResultLabel, query, VehicleinfodatagridView);
=======
            General.validTextboxEntry(label9, query, VehicleinfodatagridView);
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentBranchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        public void deleteVehicle()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("server=SYNAPSE;" +
                                    "Trusted_Connection=yes;" +
                                    "database=car-rental-agency; " +
                                    "connection timeout=30"))
=======
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
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
                {
                    connection.Open();
                    String vehicleType = vehicleTypeTextBox.Text;

<<<<<<< HEAD
                    using (SqlCommand command = new SqlCommand("DELETE FROM  Vehicle  WHERE  VehicleID  = '" + ID.ToString() + "'", connection))
                    {

                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }

=======
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
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
            catch (SystemException ex)
            {
                MessageBox.Show("Sorry Cannot delete");
            }

        }
<<<<<<< HEAD
=======


>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
        public static void fillComboBox(ComboBox cb, string colName, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string val = table.Rows[i][colName].ToString();
                cb.Items.Add(val);
            }
        }

<<<<<<< HEAD
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void DeleteVehicle_Load(object sender, EventArgs e)
=======
        private void UpdateVehicle_Load(object sender, EventArgs e)
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
        {
            populateDGV();
        }

<<<<<<< HEAD
        private void label9_Click_1(object sender, EventArgs e)
=======
        private void label9_Click(object sender, EventArgs e)
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
        {

        }

<<<<<<< HEAD
        private void button1_Click_1(object sender, EventArgs e)
        {
            queryResultLabel.Visible = true;
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
                queryResultLabel.Text = "All Fields are required!";
                queryResultLabel.ForeColor = Color.FromArgb(192, 0, 0);
            }

            else
            {
                deleteVehicle();
                // Bind_Data();
                queryResultLabel.Text = "deleted successfully to the database!";
                queryResultLabel.ForeColor = Color.FromArgb(0, 192, 0);
                populateDGV();

            }
        }

        private void VehicleinfodatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            ID = (int)VehicleinfodatagridView.Rows[e.RowIndex].Cells["VehicleID"].Value;
        }
    }
}
=======
        private void VehicleinfodatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
