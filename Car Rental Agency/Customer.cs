using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Agency
{
    public class Customer
    {
        public int ID { get; set; }

        public bool SelfServer { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string BDay { get; set; }

        public decimal PhoneNumber { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string MembershipType { get; set; }

        public string DlisenceType { get; set; }
        public string DlisenceNo { get; set; }

        // password stored is hashed
        public string Password { get; set; }

        public String PostalCode { get; set; }
        public string isEmployee { get; set; }
        public string Balance { get; set; }
        public Customer()
        {
            this.SelfServer = true;
        }
    }
}
