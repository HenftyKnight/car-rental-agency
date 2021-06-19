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
        string entryOriginalRequest;
        string entryPaymentMethod;
        string entryStatus;
        string entryMembership;
        int successfulTransactionFlag = 0;
        DateTime entryTransactionDateTime;

        public BookingCustomer(Customer cx)
        {
            InitializeComponent();
            checkavailability.Click += Checkavailability_Click;

            // Filling ComboBox for PickUp Branch
            string pickUpbranchQuery = "SELECT branchName FROM Branch;";
            DataTable pickUpbranchTable = Database.getDataTableAfterRunningQuery(pickUpbranchQuery);
            fillComboBox(pickupBranchComboBox, "branchName", pickUpbranchTable);

            // Filling ComboBox for DropOff Branch
            string dropOffbranchQuery = "SELECT branchName FROM Branch;";
            DataTable dropOffbranchTable = Database.getDataTableAfterRunningQuery(dropOffbranchQuery);
            fillComboBox(dropoffBranchComboBox, "branchName", dropOffbranchTable);

            // Filling ComboBox for Vehicle Type
            string vehicleTypeQuery = "SELECT Vtype FROM VehicleType";
            DataTable TypeTable = Database.getDataTableAfterRunningQuery(vehicleTypeQuery);
            fillComboBox(vehicleTypeComboBox, "Vtype", TypeTable);

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

            Console.WriteLine("MemberShip Type",dr);

            while (dr.Read())
            {
                entryMembership = dr["MembershipType"].ToString().TrimEnd();
                Console.WriteLine("Entry MmeberShip Type",entryMembership);
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

        private void Checkavailability_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            TimeSpan rentalTime = dropoffDateTimePicker.Value.Subtract(pickDateTimePicker.Value);
            int rentalDays = rentalTime.Days;

            Console.WriteLine("Rental Days",rentalDays);

            //StringBuilder whereVehicleTypeString = new StringBuilder("");
            //StringBuilder whereSeatsString = new StringBuilder("");
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
            //Vehicles login = new Vehicles();
            //login.Show();
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
            

        }

        private void SearchagainBtn_Click(object sender, EventArgs e)
        {
            BookingCustomer NewForm = new BookingCustomer(User);
            this.Close();
            NewForm.Show();
        }

        private bool validatePickupAndDropDateTime(int carID, DateTime pickupDateTime, DateTime dropDateTime)
        {

            string query =
                "SELECT * " +
                "FROM [Booking] " +
                $"WHERE VehicleID = {carID} " +
                    "AND [Booking].status = 'Success' " +
                    $"AND ((CONVERT(datetime,'{pickupDateTime.Date.ToString("d")}',103) >= FromDate AND CONVERT(datetime,'{pickupDateTime.Date.ToString("d")}',103) <= ToDate) " +
                    $"OR (CONVERT(datetime,'{dropDateTime.Date.ToString("d")}',103) >= FromDate AND CONVERT(datetime,'{dropDateTime.Date.ToString("d")}',103) < ToDate) " +
                    $"OR (CONVERT(datetime,'{pickupDateTime.Date.ToString("d")}',103) < FromDate AND CONVERT(datetime,'{dropDateTime.Date.ToString("d")}',103) > ToDate));";

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
        private DataTable findOtherCars(Double dailyRate, Double weeklyRate, Double monthyRate, DateTime pickupDateTime, DateTime dropDateTime)
        {
            string pickupBranch = pickupBranchComboBox.Text;
            string query =
                "SELECT * " +
                "FROM Vehicle, Branch, VehicleType " +
                $"WHERE Vehicle.currentBranchID = Branch.branchID " +
                    $"AND Vehicle.Vtype = VehicleType.Vtype " +
                    $"AND Branch.branchName = '{pickupBranch}' " +
                    $"AND(VehicleType.dailyRate > {dailyRate} or VehicleType.weeklyRate > {weeklyRate} or VehicleType.monthlyRate > {monthyRate}) " +
                    "AND NOT EXISTS ( " +
                        "SELECT VehicleID " +
                        "FROM [Booking] " +
                        "WHERE Vehicle.vehicleID = [Booking].VehicleID " +
                        $"AND ((CONVERT(datetime,'{pickupDateTime.Date.ToString("d")}',103) >= FromDate AND CONVERT(datetime,'{pickupDateTime.Date.ToString("d")}',103) <= ToDate) " +
                    $"OR (CONVERT(datetime,'{dropDateTime.Date.ToString("d")}',103) >= FromDate AND CONVERT(datetime,'{dropDateTime.Date.ToString("d")}',103) < ToDate) " +
                    $"OR (CONVERT(datetime,'{pickupDateTime.Date.ToString("d")}',103) < FromDate AND CONVERT(datetime,'{dropDateTime.Date.ToString("d")}',103) > ToDate)));";

            Console.WriteLine(query);

            // fill the table with the value retrie
            // ved
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
                rentalType = row.Cells["VType"].Value.ToString();
                String typeVal = row.Cells["VType"].Value.ToString();

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

                entryOriginalRequest = rentalType;
                

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dailyRate = Convert.ToDouble(dr["dailyRate"]);
                    weeklyRate = Convert.ToDouble(dr["weeklyRate"]);
                    monthyRate = Convert.ToDouble(dr["monthlyRate"]);
                }

                con.Close();

                entryCarID = Convert.ToInt32(row.Cells["vehicleID"].Value);
                DateTime pickupDateTime = pickDateTimePicker.Value;
                DateTime returnDateTime = dropoffDateTimePicker.Value;

                Console.WriteLine(pickupDateTime);
                Console.WriteLine(returnDateTime);
                Console.WriteLine(dr);
                Console.WriteLine(entryMembership);

                // If the pickup or drop off datetime are invalid
                if (!validatePickupAndDropDateTime(entryCarID, pickupDateTime, returnDateTime))
                {
                   // MessageBox.Show("OK");
                    if (entryMembership.TrimEnd() != "Gold")
                    {
                        infolabel.Text = "The car is not available at the given date. Upgrading is not allowed for Basic membership";
                        return;
                    }

                    summary = "The car you found is not available during the selected time! Looking for other cars . . \n";
                    //infoLabel.Text = sum;
                    //MessageBox.Show(summary);
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
                Console.WriteLine(rentalCost);
                // displaying the rental summary here

                summary += row.Cells["makeYear"].Value.ToString() + " "
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
                
                Console.WriteLine(summary);

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

        private void RentCarBtn_Click(object sender, EventArgs e)
        {
            if (successfulTransactionFlag == 0)
            {
                MessageBox.Show("No car rented!");
                return;
            }
            else // When the transaction is successful
            {
                successfulTransactionFlag = 0;
            }

            if (entryCarID == 5921)
            {
                VehicleInfoDataGridView.DataSource = null;
                errorLabel.Text = "Complete Search to Rent Car";
                infolabel.Text = "Waiting for Selection...";
            }
            //    else if (entryCardNumber == "")
            //    {
            //        carResultDataGridView.DataSource = null;
            //        errorLabel.Text = "No Card on File";
            //    }
            //    else if (entryCardType == "")
            //    {
            //        carResultDataGridView.DataSource = null;
            //        errorLabel.Text = "No Card on File";
            //    }
            else
            {
                con = new SqlConnection("server=SYNAPSE;" +
                                       "Trusted_Connection=yes;" +
                                       "database=car-rental-agency; " +
                                       "connection timeout=30");

                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "" +
                "SELECT branchID " +
                "FROM Branch " +
                "WHERE branchName = '" + pickupBranchComboBox.Text + "'";

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entryPickupBranchID = Convert.ToInt32(dr["branchID"].ToString());
                }

                con.Close();

                con = new SqlConnection("server=SYNAPSE;" +
                                       "Trusted_Connection=yes;" +
                                       "database=car-rental-agency; " +
                                       "connection timeout=30");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "" +
                "SELECT branchID " +
                "FROM Branch " +
                "WHERE branchName = '" + dropoffBranchComboBox.Text + "'";

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entryDropBranchID = Convert.ToInt32(dr["branchID"].ToString());
                }

                con.Close();

                entryPickupDateTime = pickDateTimePicker.Value;
                entryReturnDateTime = dropoffDateTimePicker.Value;
                entryTransactionDateTime = DateTime.Now;

                VehicleInfoDataGridView.DataSource = null;

                // Update this!
                //string getID = $"SELECT userID from Users Where fName = '{User.FirstName.ToString().TrimEnd()}';";

                //MessageBox.Show(getID);
                con = new SqlConnection("server=SYNAPSE;" +
                                       "Trusted_Connection=yes;" +
                                       "database=car-rental-agency; " +
                                       "connection timeout=30");

                con.Open();
                //cmd = new SqlCommand(getID, con);
                //dr = cmd.ExecuteReader();
                //dr.Read();
                //int uid = Int32.Parse(dr["userID"].ToString());
                //MessageBox.Show(uid.ToString());
                //dr.Close();


                string sql = $"INSERT INTO [Booking] (CustomerID, VehicleID, PickUpBranchID, DropOffBranchID, FromDate, ToDate, Total, payment, status, OriginalRequest, TransactionDateAndTime) ";
                //string values = "VALUES (@eCUID, @eVHID, @ePBID, @eDBID, @ePDT, @eDDT, @eTTL,@ePMTD, @OGRQ, @ePSTS, @eTDT);";
                String values = $"VALUES ({entryUserID}, {entryCarID}, {entryPickupBranchID}, {entryDropBranchID}, CONVERT(DateTime,'{entryPickupDateTime.Date.ToString("d")}',103), CONVERT(DateTime,'{entryReturnDateTime.Date.ToString("d")}',103), {entryAmount},'{entryPaymentMethod}', '{entryStatus}', '{entryOriginalRequest.ToString().TrimEnd()}',CONVERT(DateTime,'{entryTransactionDateTime.Date.ToString("d")}',103));";
                string insertvals = sql + values;
                //MessageBox.Show(entryPickupDateTime.Date.ToString("d"));
                int returnStatus = 0;

                Console.WriteLine(insertvals);

                cmd = new SqlCommand(insertvals, con);
                //MessageBox.Show(entryUserID, "Entry UserID");
                //cmd.Parameters.Add("@eCUID", SqlDbType.Int).Value = entryUserID.ToString();
                //cmd.Parameters.Add("@eVHID", SqlDbType.Int).Value = entryCarID;
                //cmd.Parameters.Add("@ePBID", SqlDbType.Int).Value = entryPickupBranchID;
                //cmd.Parameters.Add("@eDBID", SqlDbType.Int).Value = entryDropBranchID;
                //cmd.Parameters.Add("@ePDT", SqlDbType.DateTime).Value = entryPickupDateTime;
                //cmd.Parameters.Add("@eDDT", SqlDbType.DateTime).Value = entryReturnDateTime;
                //cmd.Parameters.Add("@eTTL", SqlDbType.Decimal).Value = entryAmount;
                //cmd.Parameters.Add("@ePMTD", SqlDbType.VarChar).Value = entryPaymentMethod;
                //cmd.Parameters.Add("@eOGRQ", SqlDbType.VarChar).Value = entryOriginalRequest;
                //cmd.Parameters.Add("@ePSTS", SqlDbType.VarChar).Value = entryStatus;
                //cmd.Parameters.Add("@eTDT", SqlDbType.DateTime).Value = entryTransactionDateTime;

               // MessageBox.Show(insertvals);
                returnStatus = cmd.ExecuteNonQuery();
                Console.WriteLine(returnStatus);
                con.Close();
                
                if (returnStatus > 0)
                {
                    int customerTransations = 0;
                    con = new SqlConnection("server=SYNAPSE;" +
                                       "Trusted_Connection=yes;" +
                                       "database=car-rental-agency; " +
                                       "connection timeout=30");
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;

                    cmd.CommandText = "" +
                        "select COUNT(Users.userID) as noTransactions " +
                        "from Users, [Booking] " +
                        "where Users.userID = [Booking].CustomerID " +
                        "and Users.userID = " + entryUserID.ToString() + " " +
                        "and status = 'Success' " +
                        "and YEAR(FromDate) = YEAR(getdate())";
                    
                   
                    dr = cmd.ExecuteReader();
                   

                    while (dr.Read())
                    {
                        customerTransations = Convert.ToInt32(dr["noTransactions"]);
                    }
                    con.Close();
                    
                    Console.WriteLine(customerTransations);
                    Console.WriteLine(entryMembership);

                    //MessageBox.Show(customerTransations.ToString());
                    
                    int rowUpdated = 0;
                    if (customerTransations>=3 && entryMembership.ToString().TrimEnd() == "Basic")
                    {
                        con = new SqlConnection("server=SYNAPSE;" +
                                       "Trusted_Connection=yes;" +
                                       "database=car-rental-agency; " +
                                       "connection timeout=30");
                        cmd = new SqlCommand();
                        con.Open();
                        cmd.Connection = con;
                        Console.WriteLine("Inside the Gold");

                        //MessageBox.Show(entryUserID.ToString(),"Inside Gold Entry User ID");
                        cmd.CommandText = "UPDATE Users SET MembershipType = 'Gold' Where userID = " + entryUserID.ToString();

                        //this.User.ID
                        
                        rowUpdated = cmd.ExecuteNonQuery();
                        Console.WriteLine(rowUpdated);
                        con.Close();
                    }

                    if (rowUpdated > 0)
                    {
                        MessageBox.Show("Car Rental Successfull! YOU ARE NOW A GOLD MEMBER! ", "Success and New Membership");
                    }
                    else
                    {
                        MessageBox.Show("Car Rental Successfull!", "Success");
                    }
                    //this.Close();
                }
            }
        }

        private void backUpDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}