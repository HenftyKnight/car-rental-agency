﻿using System;
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
<<<<<<< HEAD
    
    public partial class DeleteBranch : Form
    {
        int branch_id;
        string id;
        public DeleteBranch()
        {
            InitializeComponent();
            string branchQuery = "SELECT branchName FROM Branch;";
            DataTable branchTable = Database.getDataTableAfterRunningQuery(branchQuery);
            fillComboBox(branchNameComboBox, "branchName", branchTable);
        }

        private void branchInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
=======
    public partial class delBranch : Form
    {
        int branch_id;
        string id;
        public delBranch()
        {
            InitializeComponent();
            branchSearchBtn.Click += BranchSearchBtn_Click;


            // Filling the ComboBox
            string branchQuery = "SELECT branchName FROM Branch;";
            DataTable branchTable = Database.getDataTableAfterRunningQuery(branchQuery);
            fillComboBox(branchNameComboBox, "branchName", branchTable);

            // DataGridView to TextBox

            branchInfoDataGridView.CellClick += BranchInfoDataGridView_CellClick;
        }

        private void BranchInfoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
        {
            branchInfoDataGridView.CurrentRow.Selected = true;

            id = branchInfoDataGridView.Rows[e.RowIndex].Cells["branchID"].Value.ToString();
            brNameTbox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["branchName"].Value.ToString();
            streetTbox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["street"].Value.ToString();
            cityTextBox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["city"].Value.ToString();
            stateTBox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["state"].Value.ToString();
            countryTBox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["country"].Value.ToString();
            postalCodeTbox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["postalcode"].Value.ToString();
            phoneTbox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["phone"].Value.ToString();

            branch_id = (int)branchInfoDataGridView.Rows[e.RowIndex].Cells["branchID"].Value;
        }

<<<<<<< HEAD
        private void branchSearchBtn_Click(object sender, EventArgs e)
        {
=======
        private void BranchSearchBtn_Click(object sender, EventArgs e)
        {


>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
            queryResultlabel.Visible = true;

            if (branchNameComboBox.SelectedIndex == -1)
            {
                queryResultlabel.Text = "Uh oh! Cannot Find the Branch Name";
                queryResultlabel.ForeColor = Color.FromArgb(0, 192, 0);
            }

            else
            {
                string branchName = branchNameComboBox.SelectedItem.ToString();

                String query = $"SELECT * FROM Branch WHERE branchName = '{branchName}';";
                DataTable table = Database.getDataTableAfterRunningQuery(query);
                General.validTextboxEntry(queryResultlabel, query, branchInfoDataGridView);
            }
        }

<<<<<<< HEAD
=======
        private void branchGroupBox_Enter(object sender, EventArgs e)
        {

        }

>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
        public static void fillComboBox(ComboBox cb, string colName, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string val = table.Rows[i][colName].ToString();
                cb.Items.Add(val);
            }
        }

        private void updateBranchBtn_Click(object sender, EventArgs e)
        {
            queryResultlabel.Visible = true;
            String branchName = brNameTbox.Text.TrimEnd();
            String street = streetTbox.Text.TrimEnd();
            String city = cityTextBox.Text.TrimEnd();
            String state = stateTBox.Text.TrimEnd();
            String country = countryTBox.Text.TrimEnd();
            String phone = phoneTbox.Text.TrimEnd();
            String postalcode = postalCodeTbox.Text.TrimEnd();

            if (branchName == "" | street == "" | city == "" | state == "" | country == "" | phone == "" | postalcode == "")
            {
                queryResultlabel.Text = "Uh oh! fields cannot be Empty";
                queryResultlabel.ForeColor = Color.FromArgb(0, 192, 0);
            }

            else
            {
                deleteBranch();
<<<<<<< HEAD

=======
                
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
                queryResultlabel.Text = "deleted successfully from the database!";
                queryResultlabel.ForeColor = Color.FromArgb(0, 192, 0);
                Bind_Data();
            }
        }

<<<<<<< HEAD
=======


>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
        public void deleteBranch()
        {



            try
            {
<<<<<<< HEAD
                using (SqlConnection connection = new SqlConnection("server=SYNAPSE;" +
=======
                using (SqlConnection connection = new SqlConnection("server=DESKTOP-FN58B5T;" +
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
                                        "Trusted_Connection=yes;" +
                                        "database=car-rental-agency; " +
                                        "connection timeout=30"))
                {
                    connection.Open();
<<<<<<< HEAD

=======
                    
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28

                    using (SqlCommand command = new SqlCommand("DELETE FROM  Branch  WHERE  branchID  = '" + branch_id + "'", connection))
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


        void Bind_Data()
        {
            String query = $"SELECT * FROM Branch;";
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            General.validTextboxEntry(queryResultlabel, query, branchInfoDataGridView);

        }

<<<<<<< HEAD
        private void DeleteBranch_Load(object sender, EventArgs e)
        {
            Bind_Data();
        }
    }
}
=======
        private void UpdateBranch_Load(object sender, EventArgs e)
        {
            Bind_Data();
        }

        private void updatebranchpanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }

}
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
