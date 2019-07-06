using Microsoft.EntityFrameworkCore.Migrations;

namespace MosqueManagement.Web.Migrations
{
    public partial class RequiredFiedandDefaults2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
