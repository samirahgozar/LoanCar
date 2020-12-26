using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanCar.Data.Migrations
{
    public partial class modifyLoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Trade",
                schema: "fac",
                table: "Loan",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                schema: "fac",
                table: "Loan",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DownPMT",
                schema: "fac",
                table: "Loan",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DocFEE",
                schema: "fac",
                table: "Loan",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Difference",
                schema: "fac",
                table: "Loan",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BalanceOwing",
                schema: "fac",
                table: "Loan",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Trade",
                schema: "fac",
                table: "Loan",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                schema: "fac",
                table: "Loan",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DownPMT",
                schema: "fac",
                table: "Loan",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DocFEE",
                schema: "fac",
                table: "Loan",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Difference",
                schema: "fac",
                table: "Loan",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BalanceOwing",
                schema: "fac",
                table: "Loan",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);
        }
    }
}
