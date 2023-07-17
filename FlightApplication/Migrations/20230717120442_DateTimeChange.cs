using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightApplication.Migrations
{
    /// <inheritdoc />
    public partial class DateTimeChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromTime",
                table: "FlightTicket");

            migrationBuilder.RenameColumn(
                name: "ToTime",
                table: "FlightTicket",
                newName: "Time");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "FlightTicket",
                newName: "ToTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "FromTime",
                table: "FlightTicket",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
