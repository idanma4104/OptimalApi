using Microsoft.EntityFrameworkCore.Migrations;

namespace OptimalApi.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_xAccountContact_Invite_InviteID",
                table: "xAccountContact");

            migrationBuilder.DropIndex(
                name: "IX_xAccountContact_InviteID",
                table: "xAccountContact");

            migrationBuilder.DropColumn(
                name: "InviteID",
                table: "xAccountContact");

            migrationBuilder.AddColumn<int>(
                name: "AccountID",
                table: "Invite",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invite_AccountID",
                table: "Invite",
                column: "AccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invite_Account_AccountID",
                table: "Invite",
                column: "AccountID",
                principalTable: "Account",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invite_Account_AccountID",
                table: "Invite");

            migrationBuilder.DropIndex(
                name: "IX_Invite_AccountID",
                table: "Invite");

            migrationBuilder.DropColumn(
                name: "AccountID",
                table: "Invite");

            migrationBuilder.AddColumn<int>(
                name: "InviteID",
                table: "xAccountContact",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_xAccountContact_InviteID",
                table: "xAccountContact",
                column: "InviteID");

            migrationBuilder.AddForeignKey(
                name: "FK_xAccountContact_Invite_InviteID",
                table: "xAccountContact",
                column: "InviteID",
                principalTable: "Invite",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
