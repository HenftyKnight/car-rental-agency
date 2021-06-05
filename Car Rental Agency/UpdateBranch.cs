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
    public partial class UpdateBranch : Form
    {
        public UpdateBranch()
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
        {
            branchInfoDataGridView.CurrentRow.Selected = true;
            brNameTbox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["branchName"].Value.ToString();
            streetTbox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["street"].Value.ToString();
            cityTextBox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["city"].Value.ToString();
            stateTBox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["state"].Value.ToString();
            countryTBox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["country"].Value.ToString();
            postalCodeTbox.Text = branchInfoDataGridView.Rows[e.RowIndex].Cells["postalcode"].Value.ToString();
            phoneTbox.Text =  branchInfoDataGridView.Rows[e.RowIndex].Cells["phone"].Value.ToString();
            
        }

        private void BranchSearchBtn_Click(object sender, EventArgs e)
        {
            

            queryResultLabel.Visible = true;

            if (branchNameComboBox.SelectedIndex == -1)
            {
                queryResultLabel.Text = "Uh oh! Cannot Find the Branch Name";
                queryResultLabel.ForeColor = Color.FromArgb(0, 192, 0);
            }
            
            else 
            {
                string branchName = branchNameComboBox.SelectedItem.ToString();

                String query = $"SELECT * FROM Branch WHERE branchName = '{branchName}';";
                DataTable table = Database.getDataTableAfterRunningQuery(query);
                General.validTextboxEntry(queryResultLabel, query, branchInfoDataGridView);
            }
        }   

        private void branchGroupBox_Enter(object sender, EventArgs e)
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

        private void updateBranchBtn_Click(object sender, EventArgs e)
        {
            queryResultLabel.Visible = true;
            String branchName = brNameTbox.Text.TrimEnd();
            String street = streetTbox.Text.TrimEnd();
            String city = cityTextBox.Text.TrimEnd();
            String state = stateTBox.Text.TrimEnd();
            String country = countryTBox.Text.TrimEnd();
            String phone = phoneTbox.Text.TrimEnd();
            String postalcode = postalCodeTbox.Text.TrimEnd();

            if (branchName == "" | street == "" | city == "" | state == "" | country == "" | phone == "" | postalcode == "")
            {
                queryResultLabel.Text = "Uh oh! fields cannot be Empty";
                queryResultLabel.ForeColor = Color.FromArgb(0, 192, 0);
            }

            else 
            {
                String query = $"UPDATE Branch SET branchName = '{branchName}', street = '{street}', city = '{city}',state = '{state}', country = '{country}', postalcode = '{postalcode}', phone = '{phone}' WHERE branchName = '{branchName}';";
                Database.runQuery(query);
                Bind_Data();
            }
        }

        void Bind_Data() 
        {
            String query = $"SELECT * FROM Branch;";
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            General.validTextboxEntry(queryResultLabel, query, branchInfoDataGridView);

        }

        private void UpdateBranch_Load(object sender, EventArgs e)
        {
            Bind_Data();
        }

        private void updatebranchpanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }

}
