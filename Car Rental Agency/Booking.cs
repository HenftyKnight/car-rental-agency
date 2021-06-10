using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Car_Rental_Agency
{
    public class Booking
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        Customer User;

        int entryCustomerID;
        int entryCarID = 5921;
        int entryPickupBranchID;
        int entryDropBranchID;
        DateTime entryPickupDateTime; // From Date
        DateTime entryReturnDateTime; // To Date
        double entryTotal;
        string entryPaymentMethod;
        string entryStatus;          // ?? 
        string entryMembership;
        int successfulTransactionFlag = 0;
        DateTime entryTransactionDateTime;
    }
}
