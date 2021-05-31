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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            this.Text = "Car Rental Agency";
            Customer.Click += Customer_click;
            Employee.Click += Employee_click;
        }

        /* When Clicked on the Customer Login this 
         * button takes you to the Customer Login or SignUp Page
         * From where the customer can start filling information or login!
         */
        private void Customer_click(object sender, EventArgs e)
        {
            CustomerLogin login = new CustomerLogin();
            login.Show();
            this.Text = "Button One Clicked";
        }

        /* Login to Employee Portal */
        private void Employee_click(object sender, EventArgs e)
        {

            EmployeeLogin employeeLogin = new EmployeeLogin();
            employeeLogin.Show();
            this.Text = "Button One Clicked";
        }
    }
}
