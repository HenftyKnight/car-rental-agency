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
    public partial class BookingCustomer : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        Customer User;

        int entryUserID;
        int entryCarID = 5921;
        int entryPickupBranchID;
        int entryDropBranchID;
        DateTime entryPickupDateTime;
        DateTime entryReturnDateTime;
        double entryAmount;
        //string entryCardNumber;
        //string entryCardType;
        string entryPaymentMethod;
        string entryStatus;
        string entryMembership;
        int successfulTransactionFlag = 0;
        DateTime entryTransactionDateTime;
        public BookingCustomer(Customer cx)
        {
            InitializeComponent();
            this.User = cx;
            if (cx == null)
            {
                this.User = new Customer();
                this.User.FirstName = "Guest";
            }

            con = new SqlConnection("server=SYNAPSE;" +
                                       "Trusted_Connection=yes;" +
                                       "database=car-rental-agency; " +
                                       "connection timeout=30");

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "" +
                "select MembershipType " +
                "from Users " +
                "where userID = " + this.User.ID;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                entryMembership = dr["MembershipType"].ToString();
            }

            if (entryMembership == "Gold")
            {
                welcomeLabel.ForeColor = Color.Gold;
                welcomeLabel.Text = "★ Welcome Gold Member " + User.FirstName + " ★";
            }
            else welcomeLabel.Text = "Welcome " + User.FirstName;

            entryUserID = this.User.ID;
            //entryCardType = this.User.cardType;
            //entryCardNumber = this.User.cardNumber;
            entryPaymentMethod = "Online";
            entryStatus = "Success";

            pickDateTimePicker.Value = DateTime.Now;
            dropoffDateTimePicker.Value = DateTime.Now;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicles login = new Vehicles();
            login.Show();
        }

        private void pickupBranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            infolabel.Text = "Selecting Pick Up Branch";
            errorLabel.Text = "";
        }

        private void dropoffBranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            infolabel.Text = "Selecting Drop Off Branch";
            errorLabel.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            TimeSpan rentalTime = dropoffDateTimePicker.Value.Subtract(pickDateTimePicker.Value);
            int rentalDays = rentalTime.Days;

            StringBuilder whereVehicleTypeString = new StringBuilder("");
            StringBuilder whereSeatsString = new StringBuilder("");
            //StringBuilder whereString = new StringBuilder("");
            //StringBuilder whereTransmissionString = new StringBuilder("");

            // Need to add more code for complex queries from here
        }
    }
}
