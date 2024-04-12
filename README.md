# TCG-Inventory-Management-Application
Our project is an inventory system application called TCG Inventory System, which can also act as a point-of-sale system for trading card stores. Our system will use API calls to retrieve the market price of cards and convert them to Canadian pricing with the latest exchange rate from USD to CAD, which is acquired from another API and stored in the database. For this application project, we use .Net Core framework for the back end, Microsoft SQL Server as the database, and Windows Forms for the front end. The main focus of the TCG Inventory System is to provide store owners with all the tools they need in one place. Users can look up card information and have the value of that card converted to Canadian currency for them in our system without the need to search for conversion rate. The system will also give users reports on any noticeable change in the market price of any card each day. Users can see the card market trend at a date range they chose. Our system is also integrated with Google log-in API, allowing users to create an account with their Google mail.

Setting up
Database Connection
You will need to change the server name in the connection string to your database server to connect the app to your database. You will find the connection string variable in the Program.cs file.

Running Application
When running the app for the first time every day, the app will take some time to update the database with the current market price and exchange rate.
