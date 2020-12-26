using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanCar.Data.Migrations
{
    public partial class ContactMessageAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                schema: "fac",
                table: "Contact",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                schema: "fac",
                table: "Contact");
        }
    }
}
