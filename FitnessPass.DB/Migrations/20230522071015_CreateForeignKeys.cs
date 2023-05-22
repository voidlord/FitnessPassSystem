using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPass.DB.Migrations
{
    /// <inheritdoc />
    public partial class CreateForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GymId",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "GymId",
                table: "ClientPass");

            migrationBuilder.RenameColumn(
                name: "PassId",
                table: "Entries",
                newName: "PassTypePassId");

            migrationBuilder.RenameColumn(
                name: "PassId",
                table: "ClientPass",
                newName: "PassTypePassId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_ClientId",
                table: "Entries",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_PassTypePassId",
                table: "Entries",
                column: "PassTypePassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPass_ClientId",
                table: "ClientPass",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPass_PassTypePassId",
                table: "ClientPass",
                column: "PassTypePassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientPass_Client_ClientId",
                table: "ClientPass",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientPass_PassType_PassTypePassId",
                table: "ClientPass",
                column: "PassTypePassId",
                principalTable: "PassType",
                principalColumn: "PassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_Client_ClientId",
                table: "Entries",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_PassType_PassTypePassId",
                table: "Entries",
                column: "PassTypePassId",
                principalTable: "PassType",
                principalColumn: "PassId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientPass_Client_ClientId",
                table: "ClientPass");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientPass_PassType_PassTypePassId",
                table: "ClientPass");

            migrationBuilder.DropForeignKey(
                name: "FK_Entries_Client_ClientId",
                table: "Entries");

            migrationBuilder.DropForeignKey(
                name: "FK_Entries_PassType_PassTypePassId",
                table: "Entries");

            migrationBuilder.DropIndex(
                name: "IX_Entries_ClientId",
                table: "Entries");

            migrationBuilder.DropIndex(
                name: "IX_Entries_PassTypePassId",
                table: "Entries");

            migrationBuilder.DropIndex(
                name: "IX_ClientPass_ClientId",
                table: "ClientPass");

            migrationBuilder.DropIndex(
                name: "IX_ClientPass_PassTypePassId",
                table: "ClientPass");

            migrationBuilder.RenameColumn(
                name: "PassTypePassId",
                table: "Entries",
                newName: "PassId");

            migrationBuilder.RenameColumn(
                name: "PassTypePassId",
                table: "ClientPass",
                newName: "PassId");

            migrationBuilder.AddColumn<int>(
                name: "GymId",
                table: "Entries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GymId",
                table: "ClientPass",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
