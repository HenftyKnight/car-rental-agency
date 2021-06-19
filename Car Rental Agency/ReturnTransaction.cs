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
    public partial class ReturnTransaction : Form
    {
        int id;
        String vtype;
        int CID;
        int Book_id;
        float changeBranch_fee;
        DateTime V_returnDate;
        DateTime V_dueDate;
        DateTime V_pickDate;
        float late_fee;
        float  totalLate_days;
        float totalRent_days;
        float late_charge;
        float Pay_rate;
        String Pickup_Branch;
        String Drop_ID;
        String status;
        float rentalCost = 0;

        string customerMembership;
        public ReturnTransaction()
        {
            InitializeComponent();
            CheckReturnbutton.Click += checkbookingbutton_Click;


            string branchQuery = "SELECT branchName FROM Branch;";
            DataTable branchTable = Database.getDataTableAfterRunningQuery(branchQuery);
            fillComboBox(dropOffBranch, "branchName", branchTable);

            ReturnVehicleInfodataGridView1.CellValueChanged += ReturnVehicleInfodataGridView1_CellValueChanged;

        }

        private void ReturnTransaction_Load(object sender, EventArgs e)
        {

        }
        private void ReturnVehicle_Load(object sender, EventArgs e)
        {

        }
        public static void fillComboBox(ComboBox cb, string colName, DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string val = table.Rows[i][colName].ToString();
                cb.Items.Add(val);
            }
        }


        private void branchNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void payButton_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ReturnVehicleInfodataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)


        {
            if (ReturnVehicleInfodataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = ReturnVehicleInfodataGridView1.CurrentRow;

                int currentColIndex = ReturnVehicleInfodataGridView1.CurrentCell.ColumnIndex;
                var update = ReturnVehicleInfodataGridView1.CurrentCell.Value;

                string query;
                string queryTable = "Booking";   // Query to DB for Branch Table
                string keyName = "BookingID";    // finding a keyword

                var ID = row.Cells[keyName].Value;


                switch (currentColIndex)
                {
                    case 1:
                        query = $"UPDATE {queryTable} SET branchName = '{update}' WHERE {keyName} = {ID}";
                        break;

                    case 2:
                        query = $"UPDATE {queryTable} SET street = '{update}' WHERE {keyName} = {ID}";
                        break;

                    case 3:
                        query = $"UPDATE {queryTable} SET city = '{update}' WHERE {keyName} = {ID}";
                        break;

                    case 4:
                        query = $"UPDATE {queryTable} SET state = '{update}' WHERE {keyName} = {ID}";
                        break;

                    case 5:
                        query = $"UPDATE {queryTable} SET country = '{update}' WHERE {keyName} = {ID}";
                        break;

                    case 6:
                        query = $"UPDATE {queryTable} SET postalcode = '{update}' WHERE {keyName} = {ID}";
                        break;

                    case 7:
                        query = $"UPDATE {queryTable} SET phone = '{update}' WHERE {keyName} = {ID}";
                        break;

                    default:
                        return;
                }
                Database.runQuery(query);
            }
        }


        private void checkbookingbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Return_Enter(object sender, EventArgs e)
        {

        }

        public void calculate_cost()
        {
            float dailyRate;
            float weeklyRate;
            float monthyRate;
           
            float rentalMonths = 0;
            float rentalWeeks = 0;
            //double changeBranchFee = 50;


            VehicleCostTextBox.Text = VTypeGrid.Rows[0].Cells[1].Value.ToString(); // Daily Cost
            
            dailyRate = float.Parse(VTypeGrid.Rows[0].Cells[1].Value.ToString());         // dailyRate from Booking
            //MessageBox.Show(dailyRate.ToString(), "dailyRate");
            
            weeklyRate = float.Parse(VTypeGrid.Rows[0].Cells[2].Value.ToString());
            //MessageBox.Show(weeklyRate.ToString(), "weeklyRate");// weeklyRate from Booking
            
            monthyRate = float.Parse(VTypeGrid.Rows[0].Cells[3].Value.ToString());  // monthlyRate from Booking
            //MessageBox.Show(monthyRate.ToString(), "monthyRate");
            
            late_fee = float.Parse(VTypeGrid.Rows[0].Cells[4].Value.ToString());            // lateFees
            //MessageBox.Show(late_fee.ToString(), "latefee");
            
            changeBranch_fee = float.Parse(VTypeGrid.Rows[0].Cells[5].Value.ToString());    // ChangeBranch Fee
            //MessageBox.Show(changeBranch_fee.ToString(), "CBfee");

            vtype = VTypeGrid.Rows[0].Cells[0].Value.ToString();                            // The Vehicle Type
            V_returnDate = ReturnDate.Value;                                                // ActualDropOffDate
            //MessageBox.Show(V_returnDate.ToString(), "V_returnDate");

            V_dueDate = (DateTime)ReturnVehicleInfodataGridView1.Rows[0].Cells[5].Value;    // ToDate
            //MessageBox.Show(V_dueDate.ToString(), "V_DueDate");
            V_pickDate = (DateTime)ReturnVehicleInfodataGridView1.Rows[0].Cells[4].Value;   // FromDate
            //MessageBox.Show(V_pickDate.ToString(), "V_pickDate");




            String Rent_days = (V_returnDate - V_pickDate).TotalDays.ToString("0.00");
            String Late_days = (V_returnDate - V_dueDate).TotalDays.ToString("0.00");


            //String Rent_days = (V_returnDate - V_pickDate).Days.ToString("d");
            //MessageBox.Show(Rent_days.ToString(), "Rent_days");
            
            //String Late_days = (V_returnDate - V_dueDate).Days.ToString("d");
            //MessageBox.Show(Late_days.ToString(), "Late_days");

            //MessageBox.Show(totalRent_days.ToString());
            DaysLateTextBox.Text = Late_days;  // No of Late days
            DayRenttextBox1.Text = Rent_days;  // No of the Days the Vehicle was Rented
            totalLate_days = float.Parse(Late_days); // float late days
            totalRent_days = float.Parse(Rent_days); // float total days

            customerMembership = CustomerGrid.Rows[0].Cells["MembershipType"].Value.ToString();

            //checking the branch pickup and drop pff
            Pickup_Branch = ReturnVehicleInfodataGridView1.Rows[0].Cells[6].Value.ToString();
            String drop_Branch = dropOffBranch.SelectedItem.ToString();
            String drop_B_ID = $"SELECT branchID FROM Branch WHERE branchName = '{drop_Branch}';";
            General.validTextboxEntry(genQuerylabel, drop_B_ID, InvisibleGrid);

            Drop_ID = InvisibleGrid.Rows[0].Cells[0].Value.ToString();

            // checking the late fee...
            late_charge = late_fee * totalLate_days;
            //MessageBox.Show(rentalCost.ToString(), "rentalCost");
            
            while (totalRent_days >= 28.0)
            {
                rentalCost += monthyRate;
                totalRent_days -= 28;
                rentalMonths += 1;
                //MessageBox.Show(rentalCost.ToString(), "rentalCostMonth");
                //Pay_rate = (float)(monthyRate) + late_charge;
            }

            // Total paymentover week
            while (totalRent_days >= 7.0)
            {
                rentalCost += weeklyRate;
                totalRent_days -= 7;
                rentalWeeks += 1;
                //MessageBox.Show(rentalCost.ToString(), "rentalCostWeek");
                //Pay_rate = (float)(weeklyRate) + late_charge;
            }

            if (totalLate_days >= 0.0 && customerMembership.ToString().TrimEnd() == "Basic")
            {
                rentalCost += late_charge;
            }


            //MessageBox.Show(rentalCost.ToString(), "rentalCost");

            rentalCost += totalRent_days * dailyRate;
            
            //MessageBox.Show($"'{rentalCost.ToString()}' + {totalRent_days} + {dailyRate} + {late_charge}", "rentalCost");

            


            if (Pickup_Branch != drop_Branch && customerMembership.ToString().TrimEnd() != "Gold" )
            {
                rentalCost += changeBranch_fee;
               // MessageBox.Show(rentalCost.ToString(), "rentalCost");
                //Pay_rate += changeBranch_fee;
                changeBranchTextBox.Text = changeBranch_fee.ToString();
                LateFeelTextBox.Text = late_charge.ToString();
            }

            //MessageBox.Show(rentalCost.ToString(),"rentalCost");

            


            TotalBill.Visible = true;

            TotalBill.Text = rentalCost.ToString();

            float Pay_rate = (float)rentalCost;

            Book_id = (int)ReturnVehicleInfodataGridView1.Rows[0].Cells[0].Value;
        }




        void Bind_Data()
        {
            String query = $"SELECT * FROM Booking;";
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            General.validTextboxEntry(genQuerylabel, query, ReturnVehicleInfodataGridView1);

        }

        public static void validTextboxEntry(Label label, String query, DataGridView dataGridView)
        {
            // Changing the result label
            label.Text = "Running the query . . . ";
            label.ForeColor = Color.FromArgb(0, 192, 0); //dark green

            // fill the table with the value retrieved
            DataTable table = Database.getDataTableAfterRunningQuery(query);
            // If: Resulting table after the query is empty
            if (table.Rows.Count == 0)
            {
                dataGridView.DataSource = null; // Make table empty
                MessageBox.Show("No such entry found in the database!");
            }
            // Else: Populating the table with the query result
            else { dataGridView.DataSource = table; }
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void UpdateReturn_Click(object sender, EventArgs e)
        {
            //// Updating it back to the database
            //String query = $"UPDATE Booking SET payment = 'Done' , ActualDropOffDate =  CONVERT(DateTime,'{V_returnDate.Date.ToString("d")}',103), Total = '{Pay_rate.ToString()}',OriginalRequest = '{vtype}', CustomerID = '{CID.ToString()}' , VehicleID = '{id.ToString()}', FromDate =  CONVERT(DateTime,'{V_pickDate.Date.ToString("d")}',103), ToDate =  CONVERT(DateTime,'{V_dueDate.Date.ToString("d")}',103), PickUpBranchID = '{Pickup_Branch.ToString()}',  DropOffBranchID = '{Drop_ID.ToString()}', status = 'Closed' WHERE BookingId = '{Book_id.ToString()}';";
            //Database.runQuery(query);
            //Bind_Data();

        }

        private void checkbookingbutton_Click_1(object sender, EventArgs e)
        {
            BookingResultLabel.Visible = true;
            genQuerylabel.Visible = true;

            String bookingID = BookID.Text.TrimEnd();

            if (bookingID == "")
            {
                BookingResultLabel.Text = "Uh oh! Branch Name cannot be empty!";
                BookingResultLabel.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                String query = $"SELECT * FROM Booking WHERE bookingID = '{bookingID}';";
                validTextboxEntry(BookingResultLabel, query, ReturnVehicleInfodataGridView1);

                //MessageBox.Show(query.ToString(),"bookingID");
              
                id = (int)ReturnVehicleInfodataGridView1.Rows[0].Cells["VehicleID"].Value;
                //MessageBox.Show(id.ToString(),"id");
                CID = (int)ReturnVehicleInfodataGridView1.Rows[0].Cells["CustomerID"].Value;
                
                //MessageBox.Show(CID.ToString(),"CID");
                vtype = ReturnVehicleInfodataGridView1.Rows[0].Cells["OriginalRequest"].Value.ToString();

                String query2 = $"SELECT * FROM Vehicle WHERE VehicleID = '{id}';";
                General.validTextboxEntry(genQuerylabel, query2, VehicleGrid);
                
                //MessageBox.Show(query2.ToString(), "vehicleID");


                String query3 = $"SELECT * FROM VehicleType WHERE Vtype = '{vtype}';";
                General.validTextboxEntry(genQuerylabel, query3, VTypeGrid);
                //MessageBox.Show(query3.ToString());

                String query4 = $"SELECT * FROM Users WHERE userID = '{CID}';";
                General.validTextboxEntry(genQuerylabel, query4, CustomerGrid);
                //MessageBox.Show(query4.ToString(),"userID");
                calculate_cost();
            }
        }

        private void UpdateReturn_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Updating it back to the database
                String query = $"UPDATE Booking SET payment = 'Done' , ActualDropOffDate =  CONVERT(DateTime,'{V_returnDate.Date.ToString("d")}',103), Total = {(int)float.Parse(rentalCost.ToString())},OriginalRequest = '{vtype}', CustomerID = '{CID.ToString()}' , VehicleID = '{id.ToString()}', FromDate =  CONVERT(DateTime,'{V_pickDate.Date.ToString("d")}',103), ToDate =  CONVERT(DateTime,'{V_dueDate.Date.ToString("d")}',103), PickUpBranchID = '{Pickup_Branch.ToString()}',  DropOffBranchID = '{Drop_ID.ToString()}', status = 'Closed' WHERE BookingId = {Book_id};";
                Database.runQuery(query);
                Bind_Data();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        { 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
