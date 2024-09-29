
# C# CRUD Application - Manage People Table

This is a simple C# CRUD (Create, Read, Update, Delete) application that manages a table with ID, Name, and Age fields. The application demonstrates basic database operations using Entity Framework in C# with SQL Server. 

## Table Structure

The application interacts with the following table structure:

![image](https://github.com/user-attachments/assets/590e4420-d73d-41e9-8dd3-46152d04026e)


## Prerequisites

- Visual Studio: You need to have Visual Studio installed with     .NET Core or .NET Framework support.

- SQL Server: The database is built using SQL Server. Make sure to install SQL Server or have access to a remote server.

- Entity Framework: Ensure that Entity Framework is installed to interact with the database in a C# project.

- .NET Core SDK: The application should work with any recent version of .NET Core or .NET Framework.


## Steps to Run the Application

1. Clone the Repository

Clone the project from GitHub:
```bash
  git clone https://github.com/Wafa009/CRUD Application Readme.git

```
2. Set up the Database
Create a SQL Server database to match the table structure provided above.
You can use the script provided below to create the `People` table in your database.

```bash
  CREATE TABLE People (
    ID INT PRIMARY KEY,
    Name NVARCHAR(50),
    Age INT
);

```
3. Set up the Connection String
In your C# project, navigate to the `appsettings.json` (or `Web.config` for .NET Framework) file and modify the connection string to point to your SQL Server instance.
```bash
  <connectionStrings>
<add name="ContactDB" connectionString= "Data Source=DESKTOP-M2FCJ8B\\MSSQLSERVER01;Initial Catalog=crud;Integrated Security=True;TrustServerCertificate=True;" />
</connectionStrings>
```
4. Run the Application
- Open the project in Visual Studio and build the solution.
- Run the application using IIS Express or the console.

5. Database Script Generation
To generate a script for the database in SQL Server Management Studio (SSMS):

- Right-click on the database.
- Go to Tasks > Generate Scripts.
- Follow the wizard to create a script for the database schema and data.

6. Database Backup
To create a backup of the database:

- In SQL Server Management Studio, right-click on the database you want to back up.
- Select Tasks > Back Up.
- Configure the backup settings, choose a location, and click OK to back up the database.


Features
- Create: Add new people to the database.
- Read: View the list of people in the database.
- Update: Edit existing entries.
- Delete: Remove entries from the database.


## Support

For support, email naziyatwafa@gmail.com or watch my Youtube Video https://youtu.be/9n8rwhLKTRk?si=BjmNo_EcjtCZSq4O


## License

This project is licensed under the [MIT](https://choosealicense.com/licenses/mit/) License - see the LICENSE.md file for details.

