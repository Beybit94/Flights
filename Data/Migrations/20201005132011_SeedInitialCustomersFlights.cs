using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Data.Migrations
{
    public partial class SeedInitialCustomersFlights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string[] taxnumbers = { "777777777777", "666666666666" };
            Random random = new Random();

            migrationBuilder.Sql($@"INSERT INTO Customers (FirstName,LastName,Taxnumber,BirthDate,CreateDateTime) 
                    Values (
                            'Linkin',
                            'Park',
                            '{taxnumbers[random.Next(0, taxnumbers.Length)]}',
                            '{DateTime.Now:yyyy-MM-dd h:mm t}',
                            '{DateTime.Now:yyyy-MM-dd h:mm t}'
                    )");

            migrationBuilder.Sql($@"INSERT INTO Customers (FirstName,LastName,Taxnumber,BirthDate,CreateDateTime) 
                    Values (
                            'Iron',
                            'Maiden',
                            '{taxnumbers[random.Next(0, taxnumbers.Length)]}',
                            '{DateTime.Now:yyyy-MM-dd h:mm t}','{DateTime.Now:yyyy-MM-dd h:mm t}'
                    )");


            migrationBuilder.Sql($@"INSERT INTO Flights (DepartureTime,ArrivalDateTime,DepartureCity,ArrivalCity,CustomerId,CreateDateTime) 
                    Values (
                            '{DateTime.Now:yyyy-MM-dd h:mm t}',
                            '{DateTime.Now.AddHours(1):yyyy-MM-dd h:mm t}',
                            'Almaty',
                            'Astana',
                            (SELECT Id FROM Customers WHERE FirstName = 'Linkin'),
                            '{DateTime.Now:yyyy-MM-dd h:mm t}'
                    )");

            migrationBuilder.Sql($@"INSERT INTO Flights (DepartureTime,ArrivalDateTime,DepartureCity,ArrivalCity,CustomerId,CreateDateTime) 
                    Values (
                            '{DateTime.Now:yyyy-MM-dd h:mm t}',
                            '{DateTime.Now.AddHours(1):yyyy-MM-dd h:mm t}',
                            'Astana',
                            'Almaty',
                            (SELECT Id FROM Customers WHERE FirstName = 'Iron'),
                            '{DateTime.Now:yyyy-MM-dd h:mm t}'
                    )");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Customers");
            migrationBuilder.Sql("DELETE FROM Flights");
        }
    }
}
