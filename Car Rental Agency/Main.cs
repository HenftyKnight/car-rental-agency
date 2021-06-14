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
    public partial class Main : Form
    {
        SqlConnection mysqlConnection;
        public Main()
        {
            InitializeComponent();
            this.Text = "Car Rental Agency";
            Customer.Click += Customer_click;
            Employee.Click += Employee_click;
            mysqlConnection = new SqlConnection("server=DESKTOP-FN58B5T;" +
                                       "Trusted_Connection=yes;" +
                                       "database=car-rental-agency; " +
                                       "connection timeout=30");

            try
            {
                mysqlConnection.Open();
                MessageBox.Show("Well done!");
            }

            catch (SqlException ex)
            {
                MessageBox.Show("You failed!" + ex.Message);
            }
        }

        /* When Clicked on the Customer Login this 
         * button takes you to the Customer Login or SignUp Page
         * From where the customer can start filling information or login!
         */
        private void Customer_click(object sender, EventArgs e)
        {
            CustomerLogin login = new CustomerLogin(mysqlConnection);
            login.Show();
            this.Text = "Button One Clicked";
            this.Hide();
        }

        /* Login to Employee Portal */
        private void Employee_click(object sender, EventArgs e)
        {

            EmployeeLogin employeeLogin = new EmployeeLogin(mysqlConnection);
            employeeLogin.Show();
            this.Text = "Button One Clicked";
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
