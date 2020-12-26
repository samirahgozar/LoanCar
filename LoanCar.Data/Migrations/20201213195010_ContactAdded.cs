using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanCar.Data.Migrations
{
    public partial class ContactAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "ApplicantEmployerHowLongMonth",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ApplicantEmployerHowLongYear",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<long>(
                name: "ApplicantEmployerMonthlyIncome",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ApplicantEmployerName",
                schema: "fac",
                table: "Loan",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicantEmployerOccupation",
                schema: "fac",
                table: "Loan",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ApplicantEmployerPhone",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ApplicantEmployerTwoIncome",
                schema: "fac",
                table: "Loan",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BalanceOwing",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Difference",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DocFEE",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DownPMT",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<short>(
                name: "PreviousEmployerHowLongMonth",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "PreviousEmployerHowLongYear",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "PreviousEmployerName",
                schema: "fac",
                table: "Loan",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PreviousEmployerPhone",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "SolidVehicleDamage",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "SolidVehicleKms",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "SolidVehicleMake",
                schema: "fac",
                table: "Loan",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolidVehicleModel",
                schema: "fac",
                table: "Loan",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SolidVehicleOut",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SolidVehicleRebuilt",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SolidVehicleVin",
                schema: "fac",
                table: "Loan",
                maxLength: 17,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SolidVehicleYear",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Trade",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "TradeVehicleDamage",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "TradeVehicleKms",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "TradeVehicleMake",
                schema: "fac",
                table: "Loan",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TradeVehicleModel",
                schema: "fac",
                table: "Loan",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TradeVehicleOut",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TradeVehicleRebuilt",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TradeVehicleVin",
                schema: "fac",
                table: "Loan",
                maxLength: 17,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TradeVehicleYear",
                schema: "fac",
                table: "Loan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Contact",
                schema: "fac",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Phone = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact",
                schema: "fac");

            migrationBuilder.DropColumn(
                name: "ApplicantEmployerHowLongMonth",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "ApplicantEmployerHowLongYear",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "ApplicantEmployerMonthlyIncome",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "ApplicantEmployerName",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "ApplicantEmployerOccupation",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "ApplicantEmployerPhone",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "ApplicantEmployerTwoIncome",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "BalanceOwing",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "Difference",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "DocFEE",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "DownPMT",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "PreviousEmployerHowLongMonth",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "PreviousEmployerHowLongYear",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "PreviousEmployerName",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "PreviousEmployerPhone",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "Price",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "SolidVehicleDamage",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "SolidVehicleKms",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "SolidVehicleMake",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "SolidVehicleModel",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "SolidVehicleOut",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "SolidVehicleRebuilt",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "SolidVehicleVin",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "SolidVehicleYear",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "Trade",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "TradeVehicleDamage",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "TradeVehicleKms",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "TradeVehicleMake",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "TradeVehicleModel",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "TradeVehicleOut",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "TradeVehicleRebuilt",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "TradeVehicleVin",
                schema: "fac",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "TradeVehicleYear",
                schema: "fac",
                table: "Loan");
        }
    }
}
