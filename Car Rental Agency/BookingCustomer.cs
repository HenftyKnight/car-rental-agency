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
            
            // Filling ComboBox for PickUp Branch
            string pickUpbranchQuery = "SELECT branchName FROM Branch;";
            DataTable pickUpbranchTable = Database.getDataTableAfterRunningQuery(pickUpbranchQuery);
            fillComboBox(pickupBranchComboBox,"branchName", pickUpbranchTable);

            // Filling ComboBox for DropOff Branch
            string dropOffbranchQuery = "SELECT branchName FROM Branch;";
            DataTable dropOffbranchTable = Database.getDataTableAfterRunningQuery(dropOffbranchQuery);
            fillComboBox(dropoffBranchComboBox, "branchName", dropOffbranchTable);

            // Filling ComboBox for Vehicle Type
            string vehicleTypeQuery = "SELECT Vtype FROM VehicleType";
            DataTable TypeTable = Database.getDataTableAfterRunningQuery(vehicleTypeQuery);
            fillComboBox(vehicleTypeComboBox, "Vtype", TypeTable);

            // Filling ComboBox for Vehicle Seats

            //string seats = "SELECT seats from Vehicle";
            //DataTable seatsTable = Database.getDataTableAfterRunningQuery(seats);
            //fillComboBox(seatsComboBox, "Vtype", seatsTable);

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
        public static void fillComboBox(ComboBox cb, string colName, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string val = table.Rows[i][colName].ToString();
                cb.Items.Add(val);
            }
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
            VehicleInfoDataGridView.DataSource = null;
            infolabel.Text = "Selecting Pick Up Branch";
            errorLabel.Text = "";
        }

        private void dropoffBranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehicleInfoDataGridView.DataSource = null;
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

            if (pickupBranchComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Pick Up Branch Information is empty. Please select a Pick Up Branch";
            }

            else if (dropoffBranchComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Drop Off Branch Information is empty. Please select a Drop Off Branch";
            }

            else if (vehicleTypeComboBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Vehicle Type Information is empty. Please select a Vehicle Type";
            }

            else if (seatsTextBox.Text == "")
            {
                errorLabel.Text = "Seats Information is empty. Please enter number of seats";
            }

            else if (rentalDays < 1)
            {
                errorLabel.Text = "Please select upto 1 day for rental.";
            }

            else 
            {
                con = new SqlConnection("server=SYNAPSE;" +
                                       "Trusted_Connection=yes;" +
                                       "database=car-rental-agency; " +
                                       "connection timeout=30");
                cmd = new SqlCommand();
                con.Open();

                String sqlAvailabilitystring =
                    $"SELECT vehicleID, Vtype, make, model, seats, miles, makeYear FROM Branch, Vehicle WHERE Branch.branchID = Vehicle.currentBranchID AND branchName = '{pickupBranchComboBox.Text}' AND Vehicle.vehicleAvailability = 'Yes' AND  Vtype = '{vehicleTypeComboBox.Text}' AND Vehicle.seats = '{seatsTextBox.Text}';";          

                Console.WriteLine(sqlAvailabilitystring);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlAvailabilitystring, con);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                VehicleInfoDataGridView.DataSource = dataTable;
                VehicleInfoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                VehicleInfoDataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                con.Close();

            }

        }

        private void SearchagainBtn_Click(object sender, EventArgs e)
        {
            BookingCustomer NewForm = new BookingCustomer(User);
            this.Close();
            NewForm.Show();
        }

        private bool validatePickupAndDropDateTime(int carID, string pickupDateTime, string dropDateTime)
        {

            string query =
                "select * " +
                "from [Booking] " +
                $"where vehicleID = {carID} " +
                    "and [Booking].Status = 'Success' " +
                    $"and (('{pickupDateTime}' between FromDate and ToDate) " +
                    $"or ('{dropDateTime}' between FromDate and ToDate) " +
                    $"or ('{pickupDateTime}' < FromDate and '{dropDateTime}' > ToDate));";

            Console.WriteLine(query);
            // fill the table with the value retrieved
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            // If: Resulting table after the query is empty
            if (table.Rows.Count == 0) { return true; }
            else { return false; }
        }

        /*
        * Finds any other car at the given branch with a car price higher than the current price point.
        * If a higher price car ain't available, then the we look for same price point car
        */
        private DataTable findOtherCars(Double dailyRate, Double weeklyRate, Double monthyRate, string pickupDateTime, string dropDateTime)
        {
            string pickupBranch = pickupBranchComboBox.Text;
            string query =
                "select * " +
                "from Vehicle, Branch, VehicleType" +
                $"where Vehicle.currentBranchID = Branch.branchID " +
                    $"and Vehicle.Vtype = VehicleType.Vtype " +
                    $"and Branch.branchName = '{pickupBranch}' " +
                    $"and(VehicleType.dailyRate > {dailyRate} or VehicleType.weeklyRate > {weeklyRate} or VehicleType.monthlyRate > {monthyRate}) " +
                    "and not exists ( " +
                        "select vehicleID " +
                        "from [Booking] " +
                        "where Vehicle.vehicleID = [Booking].vehicleID " +
                        $"and (('{pickupDateTime}' between FromDate and ToDate) " +
                        $"or('{dropDateTime}' between FromDate and ToDate) " +
                        $"or('{pickupDateTime}' < FromDate and '{dropDateTime}' > ToDate)));";

            Console.WriteLine(query);

            // fill the table with the value retrieved
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            // If: Resulting table after the query is empty
            if (table.Rows.Count == 0) { return null; }
            else
            {
                return table;
            }
        }

        private void VehicleInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            successfulTransactionFlag = 0;
            String summary = "";
            string rentalType;
            double rentalCost = 0;
            double dailyRate = 0;
            double weeklyRate = 0;
            double monthyRate = 0;
            double changeBranchFee = 50;

            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = VehicleInfoDataGridView.Rows[e.RowIndex];
                rentalType = row.Cells["VehicleType"].Value.ToString();
                String typeVal = row.Cells["VehicleType"].Value.ToString();

                con = new SqlConnection("server=SYNAPSE;" +
                                       "Trusted_Connection=yes;" +
                                       "database=car-rental-agency; " +
                                       "connection timeout=30");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "" +
                "SELECT dailyRate, weeklyRate, monthlyRate " +
                "FROM VehicleType " +
                "WHERE Vtype = '" + rentalType + "'";

                dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    dailyRate = Convert.ToDouble(dr["dailyRate"]);
                    weeklyRate = Convert.ToDouble(dr["weeklyRate"]);
                    monthyRate = Convert.ToDouble(dr["monthlyRate"]);
                }

                con.Close();

                entryCarID = Convert.ToInt32(row.Cells["vehicleID"].Value);
                string pickupDateTime = pickDateTimePicker.Value.ToString();
                string returnDateTime = dropoffDateTimePicker.Value.ToString();


                // If the pickup or drop off datetime are invalid
                if (!validatePickupAndDropDateTime(entryCarID, pickupDateTime, returnDateTime))
                {
                    if (entryMembership != "Gold")
                    {
                        infolabel.Text = "The car is not available at the given date. Upgrading is not allowed for Basic membership";
                        return;
                    }

                    summary = "The car you found is not available during the selected time! Looking for other cars . . \n";
                    //infoLabel.Text = sum;
                    DataTable table = findOtherCars(dailyRate, weeklyRate, monthyRate, pickupDateTime, returnDateTime);

                    if (table == null)
                    {
                        infolabel.Text = "Sorry Gold Member, No cars found! Try another Branch!";
                        return;
                    }

                    backUpDataGridView.DataSource = table;
                    row = backUpDataGridView.Rows[0];

                    entryCarID = Convert.ToInt32(row.Cells["vehicleID"].Value);
                    typeVal = row.Cells["Vtype"].Value.ToString();
                    
                }

                TimeSpan rentalTime = dropoffDateTimePicker.Value.Subtract(pickDateTimePicker.Value);
                int rentalDays = rentalTime.Days;
                int rentalMonths = 0;
                int rentalWeeks = 0;

                while (rentalDays >= 28)
                {
                    rentalCost += monthyRate;
                    rentalDays -= 28;
                    rentalMonths += 1;

                }

                while (rentalDays >= 7)
                {
                    rentalCost += weeklyRate;
                    rentalDays -= 7;
                    rentalWeeks += 1;
                }

                rentalCost += rentalDays * dailyRate;

                // displaying the rental summary here

                summary += row.Cells["year"].Value.ToString() + " "
                + row.Cells["make"].Value.ToString() + " "
                + row.Cells["model"].Value.ToString() + " ("
                + typeVal + "/"
                + row.Cells["seats"].Value.ToString() + " Seats)\n"
                + pickDateTimePicker.Value.ToString("dddd, MMMM d, yyyy")
                + " — " + dropoffDateTimePicker.Value.ToString("dddd, MMMM d, yyyy") + "\n"
                + "Breakdown: " + rentalTime.Days + " Days ==> " + rentalMonths + " Months + ($" + rentalMonths * monthyRate + ") + "
                + rentalWeeks + " Weeks ($" + rentalWeeks * weeklyRate + ") + "
                + rentalDays + " Days ($" + rentalDays * dailyRate + ")\n";

                double rentalSubtotal = rentalCost;
                
                if (dropoffBranchComboBox.Text != pickupBranchComboBox.Text && entryMembership != "Gold")
                {
                    rentalCost += changeBranchFee;
                    infolabel.Text = summary
                        + "Subtotal: $" + rentalSubtotal
                        + " + Additional Fee for Different Branch Return: $" + changeBranchFee + " = Total: " + rentalCost;
                }
                else infolabel.Text = summary + "Total: " + rentalCost;
            }
            entryAmount = rentalCost;
            successfulTransactionFlag = 1;
        }
    }
}
