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
    public partial class Employee_vehicles : Form
    {
        public Employee_vehicles()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Employee_customers login = new Employee_customers();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Add_car login = new Add_car();
            login.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Update_Car login = new Update_Car();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delete_confirm login = new Delete_confirm();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Car login = new Update_Car();
            login.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Delete_confirm login = new Delete_confirm();
            login.Show();
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            Update_Car login = new Update_Car();
            login.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Delete_confirm login = new Delete_confirm();
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
    }
}
