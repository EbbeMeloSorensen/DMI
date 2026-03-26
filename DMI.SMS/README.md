# DMI.SMS

DMI.SMS is a solution that supports management and inspection of objects from the data model utilized in the Station Management System, that was provided to DMI by COWI in 2018. The solution includes a wpf application and a console application that share the same foundation in the form of an application layer. The application layer is persistence ignorant in the way that it has an IUnitOfWorkFactory that relies on dependency injection for configuring a plugin that represents a repository which may either be a file, memory based, based on Entity Framework Core (specifically Sqlite, Postgres, or MS SQL Server) or based on the Nuget package Npgsql that supports querying a Postgres database by means of SQL.

When launching e.g. the DMI.SMS.UI.WPF application, you just have to make sure that the DMI.SMS.UI.WPF project has a project reference to the desired plugin project (starting with DMI.SMS.Persistence), and that the connection string information is available in the App.config file of the DMI.SMS.UI.WPF project. Then it should work. For the database based plugins, make sure that a database provider is available, such as locally installed one or a container based one. For the plugins based on Entity Framework Core, a database will be created during upstart if it doesn't exist already, since these projects are using code first principles.

## Generating a migration for one of the persistence plugin projects

The solution already contains 3 migrations for each of the 3 Entity Framework Core based plugin:

* DMI.SMS.Persistence.EntityFrameworkCore.SQLite
* DMI.SMS.Persistence.EntityFrameworkCore.PostgreSQL
* DMI.SMS.Persistence.EntityFrameworkCore.SqlServer

It is, however, relevant to know how to generate a migration. This is done as follows in Visual Studio:

1) Set the "DMI.SMS.Persistence.EntityFrameworkCore.Helper" project as the startup project. This projects references the Nuget packages Microsoft.EntityFrameworkCore.Design and Microsoft.EntityFrameworkCore.Tools that are required for building migrations using the Package Manager Console. This project also references all of the Entity Framework Core based projects.
2) Open the "Package Manager Console" window, and select one of the Entity Framework Core based projects as the "Default project" in the drop down box.
3) Execute the following at the prompt in the Package Manager Console window: `Add-Migration InitialMigration`. Here, "Initialigration" is the name you want to assign to the migration. Then a migration is built for the project selected in the drop down box.
4) Optionally, you can now generate the database by executing the following in the Package Mager Console window: `Update-Database`. You don't have to do this, since the database will be created during upstart due to the call to the EnsureCreated method in the static constructor of the UnitOfWorkFactory class.
5) Later, such as after having updated the data model by changing the Configure method of the SMSDbContextBase class, you can add a new migration based on the existing ones, by executing the following at the prompt: `Update

