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
    public partial class AddNewVehicleType : Form
    {
        SqlConnection mysqlConnection;
        SqlCommand mysqlCommand;
        public AddNewVehicleType(SqlConnection mysqlConnection2)
        {
            InitializeComponent();
            submitBtn.Click += SubmitBtn_Click;
            mysqlConnection = mysqlConnection2;

            mysqlCommand = new SqlCommand();
            mysqlCommand.Connection = mysqlConnection;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            queryResult.Visible = true;
            String vehicleType = carTypeTextBox.Text;
            String dailyFee = dailyFeeTextBox.Text;
            String weekyFee = weeklyFeeTextBox.Text;
            String monthlyFee = monthlyFeeTextBox.Text;
            String lateFee = lateFeeTextBox.Text;
            String changeBranchFee = changeBranchTextBox.Text;

            // Ensure all the fields are not left empty

            if (vehicleType == "" | dailyFee == "" | monthlyFee == "" | weekyFee == "" | lateFee == "" | changeBranchFee == "")
            {
                queryResult.Text = "All Fields are required";
                queryResult.ForeColor = Color.FromArgb(192, 0, 0);
            }
            else
            {
                queryResult.Text = "Added successfully to the database!";
                queryResult.ForeColor = Color.FromArgb(0, 192, 0);

                mysqlCommand.CommandText = "INSERT INTO VehicleType(VType,dailyRate, weeklyRate, monthlyRate, latefee, changeBranchFee)" +
                                        $"VALUES('{vehicleType}','{dailyFee}','{weekyFee}','{monthlyFee}','{lateFee}','{changeBranchFee}')";
                try
                {
                    mysqlCommand.ExecuteNonQuery();
                }

                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString());
                }
            }
            carTypeTextBox.Text = "";
            dailyFeeTextBox.Text = "";
            weeklyFeeTextBox.Text = "";
            monthlyFeeTextBox.Text = "";
            lateFeeTextBox.Text = "";
            changeBranchTextBox.Text = "";


        }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {


            }

        private void AddNewVehicleType_Load(object sender, EventArgs e)
        {

        }
    }
 }
