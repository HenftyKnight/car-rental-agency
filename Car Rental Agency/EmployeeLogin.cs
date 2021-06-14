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
    
    public partial class EmployeeLogin : Form
    {
        SqlConnection mysqlConnection;
        SqlCommand mysqlCommand;
        public EmployeeLogin(SqlConnection mysqlConnection2)
        {
            InitializeComponent();
            mysqlConnection = mysqlConnection2;

            mysqlCommand = new SqlCommand();
            mysqlCommand.Connection = mysqlConnection;
        }

        private void empEmail_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = true;
            String employeeEmail = employeeTextBox.Text.TrimEnd();
            String ePassword = employeepassword.Text.TrimEnd();

            if (employeeEmail == "employee@CRA.ca" && ePassword == "employee")
            {
                AddingtoDB login = new AddingtoDB(mysqlConnection);
                login.Show();
            }

            else if (employeepassword.Text == "" && employeeEmail == "")
            {

                errorLabel.Text = "Email or Password cannot be empty, Please enter a valid email or password";
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
