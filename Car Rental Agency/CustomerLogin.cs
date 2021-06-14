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
using System.Security.Cryptography;

namespace Car_Rental_Agency
{
    public partial class CustomerLogin : Form
    {
        SqlConnection mysqlConnection;   
        SqlCommand mysqlCommand;
        public Customer User { get; set; }

        public CustomerLogin(SqlConnection mysqlConnection2)
        {
            InitializeComponent();
            mysqlConnection = mysqlConnection2;

            mysqlCommand = new SqlCommand();
            mysqlCommand.Connection = mysqlConnection;
            agedateTimePicker.MinDate = new DateTime(1900, 1, 1);
            agedateTimePicker.MaxDate = new DateTime(2002, 1, 1);
            agedateTimePicker.Value = new DateTime(1990, 1, 1);

            
        }
        public void RemoveText(TextBox text, String hint, object sender, EventArgs e)
        {
            if (text.Text == hint)
            {
                if (hint.ToUpper().Contains("PASSWORD"))
                {
                    text.UseSystemPasswordChar = true;
                }
                text.Text = "";
            }
            text.ForeColor = Color.Black;
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
        public static bool CustomerAuth(string inputEmail, string inputPassword)
        {
            string database = Database.connectionString;
            string sql = "SELECT passwd FROM Users WHERE email = @email";

            SqlParameter pEmail = new SqlParameter("@email", inputEmail);
            SqlConnection connection = new SqlConnection(database);

            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.Add(pEmail);

            // check if there are any rows in the database with this email first
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    // get the password from the column as a string
                    string password = reader.GetString(0);

                    // verify hashes are equal
                    if (VerifyPassword(password, inputPassword))
                    {
                        MessageBox.Show("Successful Sign In", "Success");
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid password, please try again", "Invalid Password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username", "Invalid Username");
                    Console.WriteLine("Log in failed");
                }
            }

            connection.Close();
            return false;
        }

        public static string HashPassword(string pass)
        {
            var bytes = new UTF8Encoding().GetBytes(pass);
            byte[] hashedBytes;
            using (var algorithm = new SHA256Managed())
            {
                hashedBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashedBytes);
        }

        private static bool VerifyPassword(string storedPassword, string enteredPassword)
        {
            string hashedPassword = HashPassword(enteredPassword);

            if (hashedPassword.Equals(storedPassword))
            {
                return true;
            }
            return false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = loginemailTextBox.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Error: Email address provided is invalid", "Error");
                return;
            }
            string pass = loginpasswordTbox.Text;

            if (CustomerAuth(email, pass))
            {
                this.DialogResult = DialogResult.OK;

                // Load user details from database
                string query = String.Format("SELECT userID, fName, MembershipType, balance FROM Users WHERE email = '{0}';", email);
                DataTable table = Database.SqlQuery(query);
                this.User = new Customer();
                this.User.ID = Int32.Parse(table.Rows[0][0].ToString());
                this.User.FirstName = table.Rows[0][1].ToString();
                this.User.MembershipType = table.Rows[0][2].ToString(); // Handle
                this.User.Balance = table.Rows[0][3].ToString();

                Console.WriteLine("" +
                    "ID = {0}, " +
                    "FirstName = {1}, " +
                    "Status = {2}, " +
                    "Balance = {3}",
                    //"Card Number = {4}",
                    this.User.ID,
                    this.User.FirstName,
                    this.User.MembershipType,
                    this.User.Balance);
                //this.User.cardType,
                //this.User.cardNumber);

                this.Close();
                
                Console.WriteLine(this.User.MembershipType);

                BookingCustomer booking = new BookingCustomer(this.User);
                this.Opacity = 0.0;
                booking.ShowDialog();
                this.Opacity = 100.0;

            }

        }
        private void button1_Click(object sender, EventArgs e) 
        {
            Customer cx = new Customer();

            string email = emailTextBox.Text.Trim();
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Error: Email address provided is invalid", "Password Error");
                return;
            }

            if (psswdTextBox.Text != ConfirmPsswdTextBox.Text)
            {
                MessageBox.Show("Error: Passwords do not match", "Password Error");
                return;
            }

            //Match match = Regex.Match(cardNoBox.Text, @"[0-9]{16}");

            //if (!match.Success)
            //{
            //    MessageBox.Show("Error: Card number should be 16 numeric digits", "Invalid Card");
            //    return;
            //}

            //if (cardTypeCombo.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Please select a credit card type", "Error");
            //    return;
            //}

            // Use try-catch in case the values are not going to be compatible (ie. letters entered in Age)
            try
            {
                cx.FirstName = fName.Text.Trim();
                cx.LastName = lName.Text.Trim();
                cx.BDay = agedateTimePicker.Value.ToShortDateString();
                cx.DlisenceNo = dlisenceTextBox.Text.Trim();
                cx.DlisenceType = dlisenceType.Text.Trim();
                cx.PhoneNumber = Decimal.Parse(phone.Text);
                cx.PostalCode = postalcode.Text.Trim();
                cx.EmailAddress = email;
                cx.Password = HashPassword(ConfirmPsswdTextBox.Text.Trim());
                cx.Street = street.Text.Trim();
                cx.City = city.Text.Trim();
                cx.State = state.Text.Trim();
                cx.Country = country.Text.Trim();
                //cx.CardType = cardTypeCombo.GetItemText(cardTypeCombo.SelectedItem);
                cx.MembershipType = "Basic";
                if (insertCustomer(cx))
                {
                    MessageBox.Show("Successfully Registered as a new Customer", "Success");
                    this.DialogResult = DialogResult.OK;
                    this.User = cx;
                    this.Close();

                    BookingCustomer booking = new BookingCustomer(this.User);
                    this.Opacity = 0.0;
                    booking.ShowDialog();
                    this.Opacity = 100.0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void allowOnlyNumericalValues(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static bool insertCustomer(Customer cx)
        {
            string dbstring = Database.connectionString;
            string sql = "INSERT INTO Users (fName, lName, phone, email, age, postalcode,dLisenceNo, dLisenceType, passwd, street, city, state, country, MembershipType) ";
            string values = "VALUES (@fname, @lname, @phone, @email, @age, @postalcode,@dLisenceNo, @dLisenceType, @passwd, @street, @city, @state, @country, @membershiptype);";
            string insertvals = sql + values;
            Random random = new Random();

            using (SqlConnection connection = new SqlConnection(dbstring))
            using (SqlCommand command = new SqlCommand(insertvals, connection))
            {
                command.Parameters.Add("@fname", SqlDbType.VarChar).Value = cx.FirstName;
                command.Parameters.Add("@lname", SqlDbType.VarChar).Value = cx.LastName;
                command.Parameters.Add("@phone", SqlDbType.Decimal).Value = cx.PhoneNumber;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = cx.EmailAddress;
                command.Parameters.Add("@age", SqlDbType.Date).Value = cx.BDay;
                command.Parameters.Add("@postalcode", SqlDbType.VarChar).Value = cx.PostalCode;
                command.Parameters.Add("@dlisenceNo", SqlDbType.VarChar).Value = cx.DlisenceNo;
                command.Parameters.Add("@dlisenceType", SqlDbType.VarChar).Value = cx.DlisenceType;
                command.Parameters.Add("@street", SqlDbType.VarChar).Value = cx.Street;
                command.Parameters.Add("@city", SqlDbType.VarChar).Value = cx.City;
                command.Parameters.Add("@state", SqlDbType.VarChar).Value = cx.State;
                command.Parameters.Add("@country", SqlDbType.VarChar).Value = cx.Country;
                command.Parameters.Add("@membershiptype", SqlDbType.VarChar).Value = cx.MembershipType;
                //command.Parameters.Add("@balance", SqlDbType.VarChar).Value = cx.Balance;
                //command.Parameters.Add("@isemployee", SqlDbType.VarChar).Value = cx.isEmployee;

                if (cx.SelfServer)
                {
                    command.Parameters.Add("@passwd", SqlDbType.VarChar).Value = cx.Password;
                }
                else
                {
                    command.Parameters.Add("@passwd", SqlDbType.VarChar).Value = HashPassword(random.Next(0, 1000000000).ToString());
                }

                MessageBox.Show(insertvals);
                connection.Open();
                
                command.ExecuteNonQuery();
        
                connection.Close();

            }
            return true;
        }
    }
}
