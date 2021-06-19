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

             //delete From the DB
            delBranchButton.Click += delBranchbtn_Click;
            delVehicleButton.Click += delVehiclebtn_Click;
            delVehicleTypeButton.Click += delVehicleTypebtn_Click;

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
            try
            {
                FindVehicleType findVehicleType = new FindVehicleType();
                findVehicleType.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FindVehicleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FindVehicle findVehicle = new FindVehicle();
                findVehicle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FindBranchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FindBranch findBranch = new FindBranch();
                findBranch.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdateVehicleTypebtn_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateVehicleType updateVehicleType = new UpdateVehicleType();
                updateVehicleType.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdateVehiclebtn_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateVehicle update = new UpdateVehicle();
                update.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdateBranchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBranch updateBranch = new UpdateBranch();
                updateBranch.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

         private void delVehicleTypebtn_Click(object sender, EventArgs e)
        {
            delVehicleType delVehicleType = new delVehicleType();
           delVehicleType.Show();
        }

        private void delVehiclebtn_Click(object sender, EventArgs e)
        {
            delVehicle delVehicle = new delVehicle();
            delVehicle.Show();
        }

        private void delBranchbtn_Click(object sender, EventArgs e)
        {
            delBranch deleteBranch = new delBranch();
            deleteBranch.Show();
        }

        private void AddNewVehicleTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewVehicleType addNewVehicleType = new AddNewVehicleType(mysqlConnection);
                addNewVehicleType.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddNewVehicleButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewVehicle addNewVehicle = new AddNewVehicle(mysqlConnection);
                addNewVehicle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddNewBranchButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewBranch addNewBranch = new AddNewBranch(mysqlConnection);
                addNewBranch.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewVehicleType add_new_vehicle_type = new AddNewVehicleType(mysqlConnection);
                add_new_vehicle_type.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addNewVehicleButton_Click_1(object sender, EventArgs e)
        {

        }

        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void addGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewBooking newBooking = new AddNewBooking();
                newBooking.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void findVehicleTypeBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                FindCustomer findCustomer = new FindCustomer();
                findCustomer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void findBranchBtn_Click_1(object sender, EventArgs e)
=======
         private void button2_Click(object sender, EventArgs e)
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
        {

        }

<<<<<<< HEAD
        private void topVehicleTypeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TopVehicleType topVehicleType = new TopVehicleType();
                topVehicleType.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void topVehicleBtn_Click(object sender, EventArgs e)
        {
            try {
                TopVehicle topVehicle = new TopVehicle();
                topVehicle.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void topBranchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TopBranch topBranch = new TopBranch();
                topBranch.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void topCustomerBtn_Click(object sender, EventArgs e)
        {
            try {
                TopCustomers topCustomers = new TopCustomers();
                topCustomers.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void returnTrans_Click(object sender, EventArgs e)
        {
            try
            {
                ReturnTransaction returnTransaction = new ReturnTransaction();
                returnTransaction.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deletevehicle_Click(object sender, EventArgs e)
        {
            try {
                DeleteVehicle deleteVehicle = new DeleteVehicle();
                deleteVehicle.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try {
                DeleteVehicleType deleteVehicleType = new DeleteVehicleType();
                deleteVehicleType.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void deleteBranchBtn_Click(object sender, EventArgs e)
        {
            try {

                DeleteBranch delete = new DeleteBranch();
                delete.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

=======
        private void AddingtoDB_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
    }
}
