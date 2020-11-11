# Intern-DatabaseConnection
### Author
------------
# Thinh

#### Date: 11/11/2020

#### Objective
	Take user input information and add it to a SQL database

#### Product
	Console App DatabaseConnection

### ConsoleApp:

#### Functions
	SQLCmd.DatabaseAccess(), SQLCmd.ReadDatabase(), SQLCmd.WriteToDataBase(Person), SQLCmd.GetID(), Person.cs, Helper.CnnVal(string), Helper.GetFirstName(), Helper.GetLastName() 
	-SQLCmd.DatabaseAccess(): this method serves to call the other methods and create the Person object
	-SQLCmd.ReadDatabase(): this method functions to read from the database by checking each row to see if there is data in it, if there is data in the row print it out to the console
	-SQLCmd.WriteToDatabase(Person): this method takes the person object and inserts the new entry into the database
	-SQLCmd.GetID(): this method gets the userid from the database, which serves as the primary key, and returns the value. This allows the WriteToDatabase method to add new entries into the database without writing over previous entries
	-Person.cs: this class creates a Person object with the following properties: UserID, FirstName, LastName
	-Helper.CnnVal(string): this returns the connection string to the database via the configuration manager
	-Helper.GetFirstName(): this method gets the first name from user input
	-Helper.GetLastName(): this method gets the last name from user input

### References
- https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.executescalar?redirectedfrom=MSDN&view=dotnet-plat-ext-5.0#System_Data_SqlClient_SqlCommand_ExecuteScalar
- https://www.c-sharpcorner.com/forums/how-to-insert-data-into-database-from-c-sharp-visual-studio
- https://www.youtube.com/watch?v=Et2khGnrIqc&list=PLLWMQd6PeGY3b89Ni7xsNZddi9wD5Esv2

### My Experiences
	This project had given me some trouble, namely the SQL commands which I was unsure on how to use or how to implement in my code, however after reading tutorials onlo=ine and watching Tim Corey's video on how to connect to SQL Server, I had managed to implement my project.'

### New American Business Association 
