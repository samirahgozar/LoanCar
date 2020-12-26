using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanCar.Data.Migrations
{
    public partial class modifyLoanAllTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpouseSIN",
                schema: "fac",
                table: "Loan",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PreviousEmployerPhone",
                schema: "fac",
                table: "Loan",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PresentEmployerPhone",
                schema: "fac",
                table: "Loan",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "CpApplicantPhone",
                schema: "fac",
                table: "Loan",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicantSIN",
                schema: "fac",
                table: "Loan",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicantPhone",
                schema: "fac",
                table: "Loan",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicantEmployerPhone",
                schema: "fac",
                table: "Loan",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "SpouseSIN",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PreviousEmployerPhone",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PresentEmployerPhone",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CpApplicantPhone",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ApplicantSIN",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<long>(
                name: "ApplicantPhone",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "ApplicantEmployerPhone",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
