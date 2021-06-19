--					Documentation					--
--					CAR-RENTAL-AGENCY Group 12	    --
A relational database system to support the operations 
of a car rental agency.

Tables:-
		Users
			Vehicle
				VehicleType
						Booking
							Branch

In order to generate the tables, please run the 'createDb.sql' Script and it will 
create all the 5 tables necessary to interact with the Car Rental Agency - RDBMS.

The Application has 2 sides:-
	1) Employee Side
		|-> ADD
		|-> UPDATE
		|-> DELETE
		|-> FIND
		|-> RETURNS
		|-> POPULAR

	2) Customer Side
		|-> SIGN UP
		|-> LOGIN
		|-> BOOKING

If accessing the EMPLOYEE PART of the Application, click 'Employee Login'
once, clicked a new form will popup and would like you to add the Credentials 
for the employee, inside the,

	>'Email Text Box	  ' -> 'employee@CRA.ca'
	>'Password Text Box' -> 'employee'

This will open the Application side for the employee, on this screen the following,
ADD,
UPDATE,
FIND,
DELETE,
RETURN VEHICLE,
POPULAR  ---> Vehicle, VehicleTypes, Bookings and Branches can be added, updated, deleted
			  be found from the database.

Try Adding a Few Branches, then Few Vehicles and VehicleTypes by clicking the 'Add Branch',
'Add Vehicle', 'Add VehicleType' buttons.
Similarly after adding a new Branch, the employee can assign Vehicles to that branch, find 
vehicles in that branch etc..

The Update Buttons can be used to information for the Vehicle, Branch and VehicleType Tables.

Similar to adding Buttons, the Delete function is performed to by the 'DELETE' Buttons by 
deleting the Entries from the DATABASE.

Some Functions similar to these can be done by the 'TOP BUTTONS', which fulfill the 
purpose of the COMPLEX QUERIES of the project. It includes finding the most Popular Branch, 
Popular Customer, Popular Vehicles and Popular VehicleTypes.

Even the Return Transactions can be performed by the employees, when the Customer comes 
to Return the rented vehicle. Here the Booking Transactions can be closed and the customized 
rental reports for the Customer can be generated. The Employee can even add a new booking on
behalf of a Customer and find all the associated closed bookings.

-- 'CUSTOMER'
-> Can SIGN UP as a new Customer by Filling up the form, and can start booking vehicles
-> Existing Customers can login, through the set up email and password.

IMPORTANT NOTES FOR THE CUSTOMER SIGNUP FORM:
	- Email must contain '@email.com'
	- Driving Lisence Type Accepted values - 'Class 5','Class 7'

Booking
-> Normal Member and GOLD Member
-> Transafer to GOLD member If more than 3 transactions, within the SAME Year.
-> Normal Member - Late Fees, Change Branch Fees applicable
-> Gold Member - Free Upgrades, No Late Fees, No Change Branch Fees

--- FURTHER DESCRIBED
ADD Branch
-- For Adding a new branch Head over to the Employee Login, enter the email 'employee@CRA.ca' and password 'employee',
	Click Add Branch, a new form will pop up telling you to add details of the Branch, such as Branch Name, city, etc.
	Once Added click the 'Add Branch' button and a lable will pop up saying 'Branch Successfully added to the Database'.

ADD Vehicle and ADD VehicleType
-- Similar procedure can be followed to add a New Vehicle, by clicking on the Add Vehicle button and Filling in the 
	necessary information, regarding the Vehicles. Exact same steps can be followed to Add the Vehicle Type.

ADD A NEW BOOKING,
-- An employee can add a booking for a Customer, by selecting the CustomerID or their First and Last Names.
FIND BRANCH
-- For Finding a Branch,  Head over to the Employee Login, enter the email 'employee@CRA.ca' and password 'employee',
	Click Find Branch, a new form will pop up telling you to find details of the Branch, you can FIND the Branch by 
	searching the Name of the Branch or by entering the BranchID. The results of the queries will be shown on the
	right side on the DataGridView, if a branch if found, or a message saying 'No Such Entry Found in the Database'.

FIND VEHICLE
--- Vehicle can be Found, by clicking on the Find Vehicle button, a Vehicle can be searched by different attributes
	Such as entering the Branch, Miles, Seats and VehicleType and clicking on the SEARCH button, the results would be
	shown on the right side on the Attributes. A vehicle can also be found by searching for a specific VehicleType, such
	'SUV' and hit Search.

FIND VEHICLE TYPE
-- Enter the VehicleType inside the TextBox and Search, if results exists they would pop up, in the datagridView.

FIND CUSTOMERS
-- A Customer, can be found based on his/her Name and his/her MembershipType and City. Click Find Customers Button and 
	enter the necessary amount of data, if exists in the database they will pop up.

UPDATE BRANCH
-- A Branch can be updated, by Clicking on the 'Update Branch' Button, and searching for a specific Branch can be 
	performed by Drop down menu and selecting the desired Branch, once poped up on the DataGridView, after clicking
	twice on the BranchName or Row, once selected, these values will be automatically inserted to the textBoxes above the
	UPDATE button and the Branch Attributes can Updated, once Upate Button is clicked the query is sent to the DB and the
	results can be seen on the Updated DataGridView.

UPDATE VEHICLE AND VEHICLE TYPE
-- Similar procedure can be follwed to select a particular Vehicle or VehicleID and Update can be made.

DELETE BRANCH, VEHICLE, VEHCLETYPE
-- Deletion of Branches, Vehicles and VehicleType can be a bit trickier, if the Branch is not the Foreign key
	inside any other table the Branch can be deleted successfully, otherwise 'Sorry cannot delete Branch' Text may
	appear showing the  Branch cannot be deleted. Simialar, results can be seen while deleting A Vehicle and A Vehicle Type.

TOP (Popular) Customers, Branches, Vehicle, VehicleType
--- Queries finding the Popular Customers, Branches, Vehicle, VehicleType in the Car rental system. 
	TO BE NOTED:
			Each Popular search can be done by a single Parameter only, be it either, CITY, BRANCH, STATE, COUNTRY.
			Never enter 2 attributes for finding the popular Customers, Branches, Vehicle, VehicleTypes.

Return Transactions
-- Managed by the employees are the final / total cost transactions of the Rental Vehicle for the Given Customer,
	
	Once Clicked, search for the Customer BookingID, select the Return Date and the returned Branch, based on the.
	Booking information, the total cost of the rental would be calculted.

	Calculations Contain 
		Daily, Weekly, Monthly Fees
		Late Return Fees
		Change Branch Fees

		For a Basic/Normal member the late return and change branch fees are applicable if the car is returned after 
		the DropOffDate and/or to different Branch.

		For a Golden Member, these additional costs are not taken into consideration and if a requested vehicle is 
		not available, free upgrades are processed for the Golden Member.
		
		Once clicked, UPDATE COST button, the Transaction's Status would be 'Closed' and the user can make the Payment.

-- CUSTOMER SIDE
SIGN UP -
	Enter the customer credentials - FirstName, LastName etc
	TO BE NOTED: Email Address must contain '@email'
				 Driving Lisence Type is an INT so only numbers like 5 or 7 are acceptable.
LOGIN
	Enter email, password HIT LOGIN

-- BOOKING
Actual booking of Vehicles,
	Start by selecting the,
	Pick Up Date,
	Drop Off Date,
	Pick Up Branch,
	Drop Off Branch,
	Vehicle Type and Seats.
	
	Based on your search all the available vehicles would be displayed.
	
	NOTE:
		FOR SELECTING A VEHICLE TO "RENT", DOUBLE CLICK on the Vehicle Type.
		IF for a given period of time the Vehicle is available, you can see the
		rental summary at the bottom left screen, and HIT the RENT CAR Button.
		A Message would pop up showing 'CAR RENTAL SUCCESSFULL'.

		IF an error label, showing 
		"The Car Selected is not Available. Upgrading is not possible for Basic Member"
		The Vehicle is not currently available at the moment, please select future pickup\dropoff
		date or select a different Branch.

	FOR GOLDEN MEMBER,
		IF A VEHICLE IS NOT AVAIABLE, the Golden member can be freely upgraded to select another vehicle
		but for the charge of the previous/original selected vehicle. And additional fees will not be
		calculated for the Golden Member.