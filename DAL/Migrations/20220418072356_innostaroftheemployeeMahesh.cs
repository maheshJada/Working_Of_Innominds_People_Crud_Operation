using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class innostaroftheemployeeMahesh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "EmployeeTable",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "EmailId",
                table: "ItTable",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "PhoneNumber",
                table: "ItTable",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "PhoneNumber",
                table: "EmployeeTable",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "EmailID",
                table: "CourierTable",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "PhoneNumber",
                table: "CourierTable",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "ItTable");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "ItTable");

            migrationBuilder.DropColumn(
                name: "EmailID",
                table: "CourierTable");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "CourierTable");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "EmployeeTable",
                newName: "phoneNumber");

            migrationBuilder.AlterColumn<int>(
                name: "phoneNumber",
                table: "EmployeeTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
