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
    public partial class AddingtoDB : Form
    {
        SqlConnection mysqlConnection;
        SqlCommand mysqlCommand;
        public AddingtoDB(SqlConnection mysqlConnection2)
        {
            InitializeComponent();
            // Add Into Database
            addNewBranchButton.Click += AddNewBranchButton_Click;
            addNewVehicleButton.Click += AddNewVehicleButton_Click;
            addNewVehicleTypeButton.Click += AddNewVehicleTypeButton_Click;

            //Update From the DB
            updateBranchbtn.Click += UpdateBranchbtn_Click;
            updateVehiclebtn.Click += UpdateVehiclebtn_Click;
            updateVehicleTypebtn.Click += UpdateVehicleTypebtn_Click;

            //Find
            findBranchBtn.Click += FindBranchBtn_Click;
            findVehicleBtn.Click += FindVehicleBtn_Click;
            findVehicleTypeBtn.Click += FindVehicleTypeBtn_Click;

            mysqlConnection = mysqlConnection2;

            mysqlCommand = new SqlCommand();
            mysqlCommand.Connection = mysqlConnection;
        }

        private void FindVehicleTypeBtn_Click(object sender, EventArgs e)
        {
            FindVehicleType findVehicleType = new FindVehicleType();
            findVehicleType.Show();
        }

        private void FindVehicleBtn_Click(object sender, EventArgs e)
        {
            FindVehicle findVehicle = new FindVehicle();
            findVehicle.Show();
        }

        private void FindBranchBtn_Click(object sender, EventArgs e)
        {
            FindBranch findBranch = new FindBranch();
            findBranch.Show();
        }

        private void UpdateVehicleTypebtn_Click(object sender, EventArgs e)
        {
            UpdateVehicleType updateVehicleType = new UpdateVehicleType();
            updateVehicleType.Show();
        }

        private void UpdateVehiclebtn_Click(object sender, EventArgs e)
        {
            UpdateVehicle update = new UpdateVehicle();
            update.Show();
        }

        private void UpdateBranchbtn_Click(object sender, EventArgs e)
        {
            UpdateBranch updateBranch = new UpdateBranch();
            updateBranch.Show();
            
        }

         private void delVehicleTypebtn_Click(object sender, EventArgs e)
        {
            UpdateVehicleType updateVehicleType = new UpdateVehicleType();
            updateVehicleType.Show();
        }

        private void delVehiclebtn_Click(object sender, EventArgs e)
        {
            UpdateVehicle update = new UpdateVehicle();
            update.Show();
        }

        private void delBranchbtn_Click(object sender, EventArgs e)
        {
            UpdateBranch updateBranch = new UpdateBranch();
            updateBranch.Show();
            
        }

        private void AddNewVehicleTypeButton_Click(object sender, EventArgs e)
        {
            AddNewVehicleType addNewVehicleType = new AddNewVehicleType(mysqlConnection);
            addNewVehicleType.Show();
        }

        private void AddNewVehicleButton_Click(object sender, EventArgs e)
        {
            AddNewVehicle addNewVehicle = new AddNewVehicle(mysqlConnection);
            addNewVehicle.Show();
        }

        private void AddNewBranchButton_Click(object sender, EventArgs e)
        {
            AddNewBranch addNewBranch = new AddNewBranch(mysqlConnection);
            addNewBranch.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            AddNewVehicleType add_new_vehicle_type = new AddNewVehicleType(mysqlConnection);
            add_new_vehicle_type.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addNewVehicleButton_Click_1(object sender, EventArgs e)
        {

        }

        private void addGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
