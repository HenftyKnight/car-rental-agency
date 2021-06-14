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
    public partial class Confirm_add : Form
    {
        public Confirm_add()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FindVehicle login = new FindVehicle();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee_vehicles login = new Employee_vehicles();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee_booking login = new Employee_booking();
            login.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FindCustomer login = new FindCustomer();
            login.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delete_confirm login = new Delete_confirm();
            login.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Delete_confirm login = new Delete_confirm();
            login.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Delete_confirm login = new Delete_confirm();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             FindVehicle login = new FindVehicle();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindVehicle login = new FindVehicle();
            login.Show();
        }
    }
}
