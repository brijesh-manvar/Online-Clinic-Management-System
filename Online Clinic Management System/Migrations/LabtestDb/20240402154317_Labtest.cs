using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Clinic_Management_System.Migrations.LabtestDb
{
    /// <inheritdoc />
    public partial class Labtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Labtest",
                columns: table => new
                {
                    LabTest = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestCost = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labtest", x => x.LabTest);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Labtest");
        }
    }
}
