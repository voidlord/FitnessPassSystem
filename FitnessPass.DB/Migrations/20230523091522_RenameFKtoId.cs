using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPass.DB.Migrations
{
    /// <inheritdoc />
    public partial class RenameFKtoId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientPass_Client_ClientFK",
                table: "ClientPass");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientPass_PassType_PassTypeFK",
                table: "ClientPass");

            migrationBuilder.DropForeignKey(
                name: "FK_Entries_Client_ClientFK",
                table: "Entries");

            migrationBuilder.DropForeignKey(
                name: "FK_Entries_PassType_PassTypeFK",
                table: "Entries");

            migrationBuilder.DropForeignKey(
                name: "FK_PassType_Gym_GymFK",
                table: "PassType");

            migrationBuilder.RenameColumn(
                name: "GymFK",
                table: "PassType",
                newName: "GymId");

            migrationBuilder.RenameIndex(
                name: "IX_PassType_GymFK",
                table: "PassType",
                newName: "IX_PassType_GymId");

            migrationBuilder.RenameColumn(
                name: "PassTypeFK",
                table: "Entries",
                newName: "PassTypeId");

            migrationBuilder.RenameColumn(
                name: "ClientFK",
                table: "Entries",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Entries_PassTypeFK",
                table: "Entries",
                newName: "IX_Entries_PassTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Entries_ClientFK",
                table: "Entries",
                newName: "IX_Entries_ClientId");

            migrationBuilder.RenameColumn(
                name: "PassTypeFK",
                table: "ClientPass",
                newName: "PassTypeId");

            migrationBuilder.RenameColumn(
                name: "ClientFK",
                table: "ClientPass",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientPass_PassTypeFK",
                table: "ClientPass",
                newName: "IX_ClientPass_PassTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientPass_ClientFK",
                table: "ClientPass",
                newName: "IX_ClientPass_ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientPass_Client_ClientId",
                table: "ClientPass",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientPass_PassType_PassTypeId",
                table: "ClientPass",
                column: "PassTypeId",
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
                name: "FK_Entries_PassType_PassTypeId",
                table: "Entries",
                column: "PassTypeId",
                principalTable: "PassType",
                principalColumn: "PassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassType_Gym_GymId",
                table: "PassType",
                column: "GymId",
                principalTable: "Gym",
                principalColumn: "GymId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientPass_Client_ClientId",
                table: "ClientPass");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientPass_PassType_PassTypeId",
                table: "ClientPass");

            migrationBuilder.DropForeignKey(
                name: "FK_Entries_Client_ClientId",
                table: "Entries");

            migrationBuilder.DropForeignKey(
                name: "FK_Entries_PassType_PassTypeId",
                table: "Entries");

            migrationBuilder.DropForeignKey(
                name: "FK_PassType_Gym_GymId",
                table: "PassType");

            migrationBuilder.RenameColumn(
                name: "GymId",
                table: "PassType",
                newName: "GymFK");

            migrationBuilder.RenameIndex(
                name: "IX_PassType_GymId",
                table: "PassType",
                newName: "IX_PassType_GymFK");

            migrationBuilder.RenameColumn(
                name: "PassTypeId",
                table: "Entries",
                newName: "PassTypeFK");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Entries",
                newName: "ClientFK");

            migrationBuilder.RenameIndex(
                name: "IX_Entries_PassTypeId",
                table: "Entries",
                newName: "IX_Entries_PassTypeFK");

            migrationBuilder.RenameIndex(
                name: "IX_Entries_ClientId",
                table: "Entries",
                newName: "IX_Entries_ClientFK");

            migrationBuilder.RenameColumn(
                name: "PassTypeId",
                table: "ClientPass",
                newName: "PassTypeFK");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "ClientPass",
                newName: "ClientFK");

            migrationBuilder.RenameIndex(
                name: "IX_ClientPass_PassTypeId",
                table: "ClientPass",
                newName: "IX_ClientPass_PassTypeFK");

            migrationBuilder.RenameIndex(
                name: "IX_ClientPass_ClientId",
                table: "ClientPass",
                newName: "IX_ClientPass_ClientFK");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientPass_Client_ClientFK",
                table: "ClientPass",
                column: "ClientFK",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientPass_PassType_PassTypeFK",
                table: "ClientPass",
                column: "PassTypeFK",
                principalTable: "PassType",
                principalColumn: "PassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_Client_ClientFK",
                table: "Entries",
                column: "ClientFK",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_PassType_PassTypeFK",
                table: "Entries",
                column: "PassTypeFK",
                principalTable: "PassType",
                principalColumn: "PassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassType_Gym_GymFK",
                table: "PassType",
                column: "GymFK",
                principalTable: "Gym",
                principalColumn: "GymId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
