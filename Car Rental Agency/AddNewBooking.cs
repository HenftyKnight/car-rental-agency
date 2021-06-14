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
    public partial class AddNewBooking : Form
    {
        public AddNewBooking()
        {
            InitializeComponent();

            String query = $"SELECT fName FROM Users";
            DataTable fNameTable = Database.getDataTableAfterRunningQuery(query);
            fillComboBox(userNameComboBox, "fName", fNameTable);

            String lquery = $"SELECT lName FROM Users";
            DataTable lNameTable = Database.getDataTableAfterRunningQuery(lquery);
            fillComboBox(lastNameComboBox, "lName", lNameTable);
        }
        
        public static void fillComboBox(ComboBox cb, string colName, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string val = table.Rows[i][colName].ToString();
                cb.Items.Add(val);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            resultLabel.Visible = true;

            string userID = userIDTextBox.Text.TrimEnd();
            if (userID == "")
            {
                resultLabel.Text = "Please enter something";
                resultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }
            else
            {
                // Changing the result label
                resultLabel.Text = "Running the query . . . ";
                resultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green

                // Creating the query
                String query = $"SELECT userID, fName, MembershipType FROM Users where userID = '{userID}'";

                DataTable table = Database.getDataTableAfterRunningQuery(query);

                Customer user;
                user = new Customer();
                user.ID = Int32.Parse(table.Rows[0][0].ToString());
                user.FirstName = table.Rows[0][1].ToString();
                user.MembershipType = table.Rows[0][2].ToString();

                BookingCustomer bookingCustomer = new BookingCustomer(user);
                bookingCustomer.ShowDialog();
            }
        }

        private void numericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SearchbyUserNameBtn_Click(object sender, EventArgs e)
        {
            resultLabel.Visible = true;

            if (userNameComboBox.SelectedIndex == -1 | lastNameComboBox.SelectedIndex == -1)
            {
                resultLabel.Text = "Please Select something";
                resultLabel.ForeColor = Color.FromArgb(192, 0, 0); //dark red
            }

            else 
            {
                // Changing the result label
                resultLabel.Text = "Running the query . . . ";
                resultLabel.ForeColor = Color.FromArgb(0, 192, 0); //dark green

                // Creating the query
                String query = $"SELECT userID, fName, lName,MembershipType FROM Users where fName  = '{userNameComboBox.Text}' AND lName = '{lastNameComboBox.Text}'";

                Console.WriteLine(query);
                DataTable table = Database.getDataTableAfterRunningQuery(query);

                Customer user;
                user = new Customer();
                user.ID = Int32.Parse(table.Rows[0][0].ToString());
                user.FirstName = table.Rows[0][1].ToString();
                user.MembershipType = table.Rows[0][2].ToString();

                BookingCustomer bookingCustomer = new BookingCustomer(user);
                bookingCustomer.ShowDialog();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
