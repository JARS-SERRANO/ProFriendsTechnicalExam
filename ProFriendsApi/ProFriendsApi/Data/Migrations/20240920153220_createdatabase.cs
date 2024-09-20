using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProFriendsAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProFriendsAPI",
                columns: table => new
                {
                    SellingPrice = table.Column<double>(type: "float", nullable: false),
                    ProcessingFee = table.Column<double>(type: "float", nullable: false),
                    ReservationFee = table.Column<double>(type: "float", nullable: false),
                    ReservationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EquityTerm = table.Column<int>(type: "int", nullable: false),
                    LoanTerm = table.Column<int>(type: "int", nullable: false),
                    InterestRate = table.Column<double>(type: "float", nullable: false),
                    Insurance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProFriendsAPI", x => x.SellingPrice);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProFriendsAPI");
        }
    }
}
