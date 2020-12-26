using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanCar.Data.Migrations
{
    public partial class modifyLoanTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MortgageBalance",
                schema: "fac",
                table: "Loan",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Mortgage",
                schema: "fac",
                table: "Loan",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "MarketValue",
                schema: "fac",
                table: "Loan",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "MortgageBalance",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Mortgage",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "MarketValue",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);
        }
    }
}
