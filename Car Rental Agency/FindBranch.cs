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
    public partial class FindBranch : Form
    {
        public FindBranch()
        {
            InitializeComponent();
            searchBranchbtn.Click += SearchBranchbtn_Click;
            branchIDsearchBtn.Click += BranchIDsearchBtn_Click;
            branchInfodataGridView.CellValueChanged += BranchInfodataGridView_CellValueChanged;
        }

        private void BranchInfodataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(branchInfodataGridView.CurrentRow != null)
            {
                DataGridViewRow row = branchInfodataGridView.CurrentRow;

                int currentColIndex = branchInfodataGridView.CurrentCell.ColumnIndex;
                var update = branchInfodataGridView.CurrentCell.Value;

                string query;
                string queryTable = "Branch";   // Query to DB for Branch Table
                string keyName = "branchID";    // finding a keyword

                var ID = row.Cells[keyName].Value;

                switch(currentColIndex)
                {
                    case 1:
                        query = $"UPDATE {queryTable} SET branchName = '{update}' WHERE {keyName} = {ID}";
                        break;
                    
                    case 2:
                        query = $"UPDATE {queryTable} SET street = '{update}' WHERE {keyName} = {ID}";
                        break;

                    case 3:
                        query = $"UPDATE {queryTable} SET city = '{update}' WHERE {keyName} = {ID}";
                        break;

                    case 4:
                        query = $"UPDATE {queryTable} SET state = '{update}' WHERE {keyName} = {ID}";
                        break;

                    case 5:
                        query = $"UPDATE {queryTable} SET country = '{update}' WHERE {keyName} = {ID}";
                        break;

                    case 6:
                        query = $"UPDATE {queryTable} SET postalcode = '{update}' WHERE {keyName} = {ID}";
                        break;

                    case 7:
                        query = $"UPDATE {queryTable} SET phone = '{update}' WHERE {keyName} = {ID}";
                        break;

                    default:
                        return;
                }
                Database.runQuery(query);
            }
        }


        // Searching Branch with ID
        private void BranchIDsearchBtn_Click(object sender, EventArgs e)
        {
            branchNameResultLabel.Visible = false;
            branchIDResultlabel.Visible = true;

            string branchID = branchIDtextbox.Text.TrimEnd();
            // If text Filed is Empty
            if (branchID == "")
            {
                branchIDResultlabel.Text = "Uh oh! BranchID cannot be empty!";
                branchIDResultlabel.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                String query = $"SELECT * FROM BRANCH WHERE branchID = {branchID};";
                validTextboxEntry(branchIDResultlabel, query, branchInfodataGridView);
            }
        }

        // Searching Branch with Name
        private void SearchBranchbtn_Click(object sender, EventArgs e)
        {
            branchNameResultLabel.Visible = true;
            branchIDResultlabel.Visible = false;

            String branchName = searchBranchTextBox.Text.TrimEnd();

            if (branchName == "")
            {
                branchNameResultLabel.Text = "Uh oh! Branch Name cannot be empty!";
                branchNameResultLabel.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else 
            {
                String query = $"SELECT * FROM Branch WHERE branchName = '{branchName}';";
                validTextboxEntry(branchIDResultlabel, query, branchInfodataGridView);
                
            }
        }

        /* While Searching with the names of all the Branches */

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateBranch_Load(object sender, EventArgs e)
        {

        }

        public static void validTextboxEntry(Label label, String query, DataGridView dataGridView)
        {
            // Changing the result label
            label.Text = "Running the query . . . ";
            label.ForeColor = Color.FromArgb(0, 192, 0); //dark green

            // fill the table with the value retrieved
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            // If: Resulting table after the query is empty
            if (table.Rows.Count == 0)
            {
                dataGridView.DataSource = null; // Make table empty
                MessageBox.Show("No such entry found in the database!");
            }
            // Else: Populating the table with the query result
            else { dataGridView.DataSource = table; }
        }
    }
}
