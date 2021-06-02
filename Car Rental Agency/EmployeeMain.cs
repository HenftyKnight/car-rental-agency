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
    public partial class EmployeeMain : Form
    {
        public EmployeeMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_booking login = new Employee_booking();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_vehicles login = new Employee_vehicles();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee_customers login = new Employee_customers();
            login.Show();
        }
    }
}
