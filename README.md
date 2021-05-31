# CRA
# car-rental-agency
Customer(	CustomerID, 
		BranchID,
fName, 
lName, 
email, 
phone, 
street, 
city, 
state,
country, 
dLisenceNo, 
MembershipType, 
MembershipID)

Booking(	BookingID,
CustomerID,
VehicleID,
FromDate,
ToDate,
PickUpBranchID,
DropOffBranchID,
PickUpTime, 
DropOffTime)

Vehicles(	VehicleID,
BookingID,
Make,
Availability

Vehicle --- Branches : 

If  Many to Many Relationships :
BranchHaveVehicles( BranchID, VehicleID, Have)
BranchID is fK to Branches.
VehicleID is fK to Vehicles.

If Not Many to Many:


VehicleType(  VTypeID,
VehicleID,
BranchID,
DailyFee
WeeklyFee, 
MonthlyFee,
status,
model,
year,
seats,
name

Branches(	BranchID,
BranchName,
BookingID,
VehicleID,
city,
province,
country,
street,
branchpostalcode
phone)

Employees(	EmpID,
BranchID,
fName,
lName,
street,
city,
state,
country,
email,
phone

Transactions(  TransactionID,
BookingID,
CustomerID,
EmpID,
paymentType,
date,
status   (Done, Pending, Cancelled)
tax,
latefees,
totalAmt,
DropOffBranchID,
PickUpBranchID,
PickUpDate,
ReservedDropOffDate,
DropOffDate) 	


1)	 Customer X Booking
One to Many Relationships
A customer can have many bookings but a particular booking leads to a single customer
Hence, Booking table contains CustomerID which is ForeignKey to Customer.
2)	Booking X Vehicle
Doubt.
3)	Vehicles X VehicleType
A vehicle can have many vehicle types, but a single vehicle type will correspond to only one vehicle.
Vehicle X VehicleType is a one-to-many relationship where VehicleID is fK to Vehicles.
4)	Vehicle X Branch
A branch can have many vehicles, but a vehicle can be at one single branch.
So VehicleID is Fk to Branches from Vehicles.
NOTE: 
How to check for vehicle at different branches, like can an SUV be present at 2 branches?
Yes but not with the same VehicleID. Which in turn tells us it’s a one-to-many relationship
But how to differentiate there?
5)	Branches X Employee
A branch can have many employees, but an employee can be in one single branch.
So BranchID is fK to Employee from Branches.
6)	Employee X Transactions
An employee can manage multiple Transactions, but that single transaction cannot be managed  by multiple employees. So EmpID is fK to Transactions from Employee.
7)	Transaction X Customer
A customer can have many transactions, but a single transaction can only be done by one customer. Hence one to many relationships, So CustomerID is fK to Transactions from Customers. 
8)	“Golden Membership” can be tracked from the Transaction Table by tracking the TransactionID of the customer with the customerID, if a customerID has the COUNT of atleast 3 TransactionIDs that customer is considered a GOLD MEMBER, for that customer latefees and other additional expenses are ZEROED. And for these Customers the MembershipID is changed to GOLD from NULL. The assumption is that there can only be A GOLD membership type otherwise that field is left NULL. 

