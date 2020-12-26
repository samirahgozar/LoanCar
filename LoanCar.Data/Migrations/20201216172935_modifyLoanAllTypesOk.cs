using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanCar.Data.Migrations
{
    public partial class modifyLoanAllTypesOk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PreviousApplicantPostalCode",
                schema: "fac",
                table: "Loan",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicantPostalCode",
                schema: "fac",
                table: "Loan",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PreviousApplicantPostalCode",
                schema: "fac",
                table: "Loan",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicantPostalCode",
                schema: "fac",
                table: "Loan",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 7);
        }
    }
}
