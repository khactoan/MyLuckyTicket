using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLuckyTicket.Migrations
{
    public partial class AddRelationForUserAndTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UserID",
                table: "Ticket",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_User_UserID",
                table: "Ticket",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_User_UserID",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_UserID",
                table: "Ticket");
        }
    }
}
