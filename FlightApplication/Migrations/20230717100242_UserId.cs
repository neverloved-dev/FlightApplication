using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightApplication.Migrations
{
    /// <inheritdoc />
    public partial class UserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_FlightTicket_FlightTicketId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_FlightTicketId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "FlightTicketId1",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "FlightTicket",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FlightTicket");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FlightTicketId",
                table: "Users",
                column: "FlightTicketId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_FlightTicket_FlightTicketId",
                table: "Users",
                column: "FlightTicketId",
                principalTable: "FlightTicket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
