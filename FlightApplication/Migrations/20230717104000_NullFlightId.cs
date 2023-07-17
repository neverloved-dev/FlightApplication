using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightApplication.Migrations
{
    /// <inheritdoc />
    public partial class NullFlightId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_FlightTicket_FlightTicketId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_FlightTicketId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FlightTicketId1",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "FlightTicketId",
                table: "Users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FlightTicketId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlightTicketId1",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_FlightTicketId1",
                table: "Users",
                column: "FlightTicketId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_FlightTicket_FlightTicketId1",
                table: "Users",
                column: "FlightTicketId1",
                principalTable: "FlightTicket",
                principalColumn: "Id");
        }
    }
}
