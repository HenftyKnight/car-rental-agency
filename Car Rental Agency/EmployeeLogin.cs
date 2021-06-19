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

        public object EmailTextBox { get; private set; }

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
<<<<<<< HEAD
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
=======
            queryResult.Visible = true;
            String emailT  = email.Text.TrimEnd();
            String passT = pass.Text.TrimEnd();
            //checcking the empty string

            SqlConnection con = new SqlConnection("server=DESKTOP-FN58B5T;" +
                                       "Trusted_Connection=yes;" +
                                       "database=car-rental-agency; " +
                                       "connection timeout=30");  
            bool check = true;
          SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE isEmployee ='"+ check +"' AND email='"+ emailT +"' AND passwd='"+ passT +"'",con);  
         
            DataTable dt = new DataTable();    
          sda.Fill(dt);  
          if (dt.Rows[0][0].ToString() == "1")  
   {  
     
           AddingtoDB portal = new AddingtoDB(con);
            portal.Show(); 
   }  
   else  
   MessageBox.Show("Invalid username or password");  
  


              }
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
