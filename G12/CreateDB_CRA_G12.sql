-- Car-Rental-Agency 
-- Group-12
-- TABLES

use [car-rental-agency];

drop table Booking;
drop table Vehicle;
drop table VehicleType;
drop table Users;
drop table Branch;


create table Branch(
branchID	int primary key IDENTITY(1,1)not NULL,
branchName	varchar(20) not NULL,
street		varchar(20)	,
city		varchar(15) not NULL,
state	    char(15)	not NULL,
country     char(15)	not NULL,
postalcode  nvarchar(10)	not NULL,
phone		bigint
);

create table Users(
userID		int primary key IDENTITY(1,1) not NULL,
branchID	int foreign key references Branch(branchID),
fName			char(15) not NULL,
lName			char(15) not NULL,
email			varchar(max) not NULL,
phone			bigint not NULL,
street			varchar(15) not NULL,
postalcode		nvarchar(10) not NULL,
city			char(15) not NULL,
state			char(15) not NULL,
country			char(10) not NULL,
dLisenceNo		int not NULL,
dLisenceType	char(255) not NULL,
MembershipType	char(10) not NULL,
isEmployee		bit,
balance			int,
passwd			nvarchar(255) not NULL,
age				date not NULL,
noTransactions  int,
);

-- Specific Vehicle Type
create table VehicleType(
Vtype			char(20) primary key not NULL,
dailyRate		float not NULL,
weeklyRate		float not NULL,
monthlyRate		float not NULL,
latefee			float,
changeBranchFee	int
);


-- General Table for Vehicles
create table Vehicle(
VehicleID		int primary key IDENTITY(1,1) not NULL,
Vtype			char(20) foreign key references VehicleType(VType),
make			char(10) not NULL,
model			varchar(15),
seats			int,
miles			int,
makeYear		int,
currentBranchID	int foreign key references Branch(BranchID) on delete cascade ,
vehicleAvailability char(5),
);


create table Booking(
BookingID			int primary key IDENTITY(1,1) not NULL,
CustomerID			int foreign key references Users(userID) not NULL,
EmployeeID			int foreign key references Users(userID),
VehicleID			int foreign key references Vehicle(VehicleID)not NULL,
FromDate			smalldatetime,
ToDate				smalldatetime,
PickUpBranchID		int foreign key references Branch(BranchID) not NULL,
DropOffBranchID		int foreign key references Branch(BranchID) not NULL,
OriginalRequest		char(20) foreign key references VehicleType(VType),
payment				char(10),
ActualDropOffDate	date,
Total				int,
status				char(50),
TransactionDateAndTime datetime,
);

