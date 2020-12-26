using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanCar.Data.Migrations
{
    public partial class full : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TradeVehicleYear",
                schema: "fac",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "TradeVehicleKms",
                schema: "fac",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "SolidVehicleYear",
                schema: "fac",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "SolidVehicleKms",
                schema: "fac",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<short>(
                name: "PreviousEmployerHowLongYear",
                schema: "fac",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<short>(
                name: "PreviousEmployerHowLongMonth",
                schema: "fac",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<short>(
                name: "PreviousApplicantHowLongYear",
                schema: "fac",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<short>(
                name: "PreviousApplicantHowLongMonth",
                schema: "fac",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<string>(
                name: "OwnStatus",
                schema: "fac",
                table: "Loan",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicantMiddleName",
                schema: "fac",
                table: "Loan",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<long>(
                name: "ApplicantEmployerMonthlyIncome",
                schema: "fac",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<short>(
                name: "ApplicantEmployerHowLongYear",
                schema: "fac",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<short>(
                name: "ApplicantEmployerHowLongMonth",
                schema: "fac",
                table: "Loan",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TradeVehicleYear",
                schema: "fac",
                table: "Loan",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "TradeVehicleKms",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SolidVehicleYear",
                schema: "fac",
                table: "Loan",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SolidVehicleKms",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "PreviousEmployerHowLongYear",
                schema: "fac",
                table: "Loan",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "PreviousEmployerHowLongMonth",
                schema: "fac",
                table: "Loan",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "PreviousApplicantHowLongYear",
                schema: "fac",
                table: "Loan",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "PreviousApplicantHowLongMonth",
                schema: "fac",
                table: "Loan",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnStatus",
                schema: "fac",
                table: "Loan",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicantMiddleName",
                schema: "fac",
                table: "Loan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ApplicantEmployerMonthlyIncome",
                schema: "fac",
                table: "Loan",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "ApplicantEmployerHowLongYear",
                schema: "fac",
                table: "Loan",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "ApplicantEmployerHowLongMonth",
                schema: "fac",
                table: "Loan",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);
        }
    }
}
