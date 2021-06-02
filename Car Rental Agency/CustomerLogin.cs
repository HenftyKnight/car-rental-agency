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
    public partial class CustomerLogin : Form
    {
        SqlConnection mysqlConnection;   
        SqlCommand mysqlCommand;

        public CustomerLogin(SqlConnection mysqlConnection2)
        {
            InitializeComponent();
            mysqlConnection = mysqlConnection2;

            mysqlCommand = new SqlCommand();
            mysqlCommand.Connection = mysqlConnection;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Enter(object sender, EventArgs e)
        {
            BookingCustomer login = new BookingCustomer();
            login.Show();

            mysqlCommand.CommandText = "INSERT INTO VehicleType values ('SUV',5,5,5,5,5)";
            try { 
                mysqlCommand.ExecuteNonQuery();
            }

            catch(Exception e2) { 
                MessageBox.Show(e2.ToString());
            }


        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            BookingCustomer login = new BookingCustomer();
            login.Show();
        }

        private void InsertData() 
        {         
        }
    }
}
