using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class innostaroftheemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailId",
                table: "VisitorsTable",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "PhoneNumber",
                table: "VisitorsTable",
                maxLength: 10,
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "VisitorsTable");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "VisitorsTable");
        }
    }
}
