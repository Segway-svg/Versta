using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    senderCity = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    senderAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    customerCity = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    customerAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    packageWeight = table.Column<double>(type: "float", nullable: false),
                    deliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
