using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Solpac_Web.Migrations
{
    /// <inheritdoc />
    public partial class AddRequestToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Partner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftwareProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentSituation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentsOfRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectSituation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestNo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
