using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    ProfessorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    Building = table.Column<string>(nullable: true),
                    OfficeNumber = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: false),
                    Department = table.Column<string>(nullable: false),
                    Poistion = table.Column<string>(nullable: false),
                    Discipline = table.Column<string>(nullable: true),
                    Specialty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.ProfessorID);
                });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "ProfessorID", "Building", "Department", "Discipline", "EmailAddress", "FirstName", "LastName", "OfficeNumber", "PhoneNumber", "Poistion", "Specialty" },
                values: new object[] { 1, "Holroyd", " Mathematics and Computer Science", null, "redmond@lasalle.edu", "Michael", "Redmond", "131", "2159511096", "Associate Prof", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Professors");
        }
    }
}
