using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class innostar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CafetariaTable",
                columns: table => new
                {
                    Sno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tea = table.Column<int>(nullable: false),
                    Cofee = table.Column<int>(nullable: false),
                    GreenTea = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CafetariaTable", x => x.Sno);
                });

            migrationBuilder.CreateTable(
                name: "CourierTable",
                columns: table => new
                {
                    CourierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourierDate = table.Column<DateTime>(nullable: false),
                    EmpLocation = table.Column<string>(maxLength: 20, nullable: false),
                    EmpId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourierTable", x => x.CourierId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTable",
                columns: table => new
                {
                    EmpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(maxLength: 20, nullable: false),
                    phoneNumber = table.Column<int>(nullable: false),
                    EmailID = table.Column<string>(maxLength: 20, nullable: false),
                    EmpLocation = table.Column<string>(maxLength: 20, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    EmpCategory = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTable", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "ItTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssertId = table.Column<string>(nullable: false),
                    AssertName = table.Column<string>(maxLength: 20, nullable: false),
                    AssertDate = table.Column<DateTime>(nullable: false),
                    EmpId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintanacesTable",
                columns: table => new
                {
                    MaintanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lights = table.Column<int>(nullable: false),
                    Cameras = table.Column<int>(nullable: false),
                    Sensors = table.Column<int>(nullable: false),
                    Rooms = table.Column<string>(nullable: true),
                    Chairs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintanacesTable", x => x.MaintanceId);
                });

            migrationBuilder.CreateTable(
                name: "VisitorsTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Location = table.Column<string>(maxLength: 20, nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorsTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CafetariaTable");

            migrationBuilder.DropTable(
                name: "CourierTable");

            migrationBuilder.DropTable(
                name: "EmployeeTable");

            migrationBuilder.DropTable(
                name: "ItTable");

            migrationBuilder.DropTable(
                name: "MaintanacesTable");

            migrationBuilder.DropTable(
                name: "VisitorsTable");
        }
    }
}
