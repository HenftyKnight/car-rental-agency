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
    public partial class AddNewBranch : Form
    {
        SqlConnection mysqlConnection;
        SqlCommand mysqlCommand;
        public string PlaceHolderText { get; set; }
        public AddNewBranch(SqlConnection mysqlConnection2)
        {
            InitializeComponent();
            addBranchbutton.Click += AddBranchbutton_Click;
            mysqlConnection = mysqlConnection2;
            mysqlCommand = new SqlCommand();
            mysqlCommand.Connection = mysqlConnection;
        }

        private void AddBranchbutton_Click(object sender, EventArgs e)
        {
            querylabel.Visible = true;
            String branchName = branchNameTextbox.Text.TrimEnd();
            String streetName = branchStreetTextbox.Text;
            String cityName = branchCityTextbox.Text;
            String stateName = branchStateTextbox.Text;
            String countryName = branchCountryTextbox.Text;
            String postalcode = branchPostalcodeTextbox.Text;
            String phone = branchPhoneTextbox.Text;

            
            if (branchName == "" | streetName == "" | cityName == "" | stateName == "" | countryName == "" | postalcode == "" | phone == "")
            {
                querylabel.Text = "All the fields are required!";
                querylabel.ForeColor = Color.FromArgb(192, 0, 0);

            }

            else
            {
                querylabel.Text = "Branch Successfulyy Added to the Database";
                querylabel.ForeColor = Color.FromArgb(0, 192, 0);

                mysqlCommand.CommandText = "INSERT INTO Branch (branchName, street, city, state, country, postalcode, phone)" +
                                $"VALUES('{branchName}','{streetName}','{cityName}','{stateName}','{countryName}','{postalcode}','{phone}');";
                try
                {
                    mysqlCommand.ExecuteNonQuery();
                }

                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString());
                }

                branchNameTextbox.Text = "";
                branchStreetTextbox.Text = "";
                branchCityTextbox.Text = "";
                branchStateTextbox.Text = "";
                branchCountryTextbox.Text = "";
                branchPostalcodeTextbox.Text = "";
                branchPhoneTextbox.Text = "";
            }

        }
        private void branchcountrylabel_Click(object sender, EventArgs e)
        {

        }

        private void AddNewBranch_Load(object sender, EventArgs e)
        {

        }
    }
}
