using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCodeFirstProject.Migrations
{
    public partial class Initialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Active = table.Column<bool>(nullable: false),//bool cannot be null in C#
                    Sales = table.Column<decimal>(type: "decimal(11,2)", nullable: false),//decimals cannot be null in C#
                    Created = table.Column<DateTime>(nullable: false)//DateTime cannot be null in C#
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
