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
    public partial class Employee_booking : Form
    {
        public Employee_booking()
        {
            InitializeComponent();
        }

        private void Employee_booking_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

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
            Employee_customers login = new Employee_customers();
            login.Show();
        }
    }
}
