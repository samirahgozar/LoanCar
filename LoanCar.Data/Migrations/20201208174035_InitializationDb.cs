using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanCar.Data.Migrations
{
    public partial class InitializationDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Created",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                schema: "fac",
                table: "Loan");
        }
    }
}
