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
    public partial class FindCustomer : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public FindCustomer()
        {
            InitializeComponent();

            

            String query = "SELECT Distinct MembershipType FROM Users";
            DataTable Membershipquery = Database.getDataTableAfterRunningQuery(query);
            fillComboBox(membershipComboBox, "MembershipType", Membershipquery);

            String cityQuery = "SELECT Distinct city FROM Users";
            DataTable cityTable = Database.getDataTableAfterRunningQuery(cityQuery);
            fillComboBox(cityComboBox, "city", cityTable);

            String fnCityquery = "SELECT Distinct city FROM Users";
            DataTable fncityTable = Database.getDataTableAfterRunningQuery(fnCityquery);
            fillComboBox(fncityComboBox, "city", fncityTable);
        }
        public static void fillComboBox(ComboBox cb, string colName, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string val = table.Rows[i][colName].ToString();
                cb.Items.Add(val);
            }
        }

        private void Employee_customers_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = true;
            
            con = new SqlConnection("server=SYNAPSE;" +
                                      "Trusted_Connection=yes;" +
                                      "database=car-rental-agency; " +
                                      "connection timeout=30");
            cmd = new SqlCommand();
            con.Open();
            
            if (membershipComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "MemberShip Information is empty. Please select a MemberipType";
            }

            else if (cityComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "City Information is empty. Please select a City";
            }

            else
            {
                String sqlAvailabilitystring =
                    $"SELECT * FROM Users WHERE MembershipType = '{membershipComboBox.Text}'  AND city = '{cityComboBox.Text}';";
                
                Console.WriteLine(sqlAvailabilitystring);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlAvailabilitystring, con);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                CustomerDataGridView.DataSource = dataTable;
                CustomerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                CustomerDataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                con.Close();
            }
        }

        private void fnSearchBtn_Click(object sender, EventArgs e)
        {
                errorLabel.Visible = true;

                con = new SqlConnection("server=SYNAPSE;" +
                                          "Trusted_Connection=yes;" +
                                          "database=car-rental-agency; " +
                                          "connection timeout=30");
                cmd = new SqlCommand();
                con.Open();

                String fname = fNameTextBox.Text.TrimEnd();
                String lname = lnameTextBox.Text.TrimEnd();

                if (fncityComboBox.SelectedIndex == -1)
                {
                    errorLabel.Text = "MemberShip Information is empty. Please select a MemberipType";
                }

                else if (fNameTextBox.Text == "" | lname == "")
                {
                    errorLabel.Text = "First Name or Last Name Information is empty. Please Enter First Name or/and Last Name";
                }

                else
                {
                    String sqlAvailabilitystring =
                        $"SELECT * FROM Users WHERE fName = '{fname}' AND lName = '{lname}' AND city = '{fncityComboBox.Text}';";

                    Console.WriteLine(sqlAvailabilitystring);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlAvailabilitystring, con);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    CustomerDataGridView.DataSource = dataTable;
                    CustomerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    CustomerDataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                    con.Close();
            }
        }
    }
}
