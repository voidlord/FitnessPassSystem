using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPass.DB.Migrations
{
    /// <inheritdoc />
    public partial class MakeEverythingNotNullAndTryToFixForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PassTypePassId",
                table: "Entries",
                newName: "PassTypeFK");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Entries",
                newName: "ClientFK");

            migrationBuilder.RenameIndex(
                name: "IX_Entries_PassTypePassId",
                table: "Entries",
                newName: "IX_Entries_PassTypeFK");

            migrationBuilder.RenameIndex(
                name: "IX_Entries_ClientId",
                table: "Entries",
                newName: "IX_Entries_ClientFK");

            migrationBuilder.RenameColumn(
                name: "PassTypePassId",
                table: "ClientPass",
                newName: "PassTypeFK");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "ClientPass",
                newName: "ClientFK");

            migrationBuilder.RenameIndex(
                name: "IX_ClientPass_PassTypePassId",
                table: "ClientPass",
                newName: "IX_ClientPass_PassTypeFK");

            migrationBuilder.RenameIndex(
                name: "IX_ClientPass_ClientId",
                table: "ClientPass",
                newName: "IX_ClientPass_ClientFK");

            migrationBuilder.AlterColumn<int>(
                name: "StartTime",
                table: "PassType",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaxDailyUse",
                table: "PassType",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EntriesValidFor",
                table: "PassType",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EndTime",
                table: "PassType",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SalePrice",
                table: "ClientPass",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstUsedOn",
                table: "ClientPass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "PassTypePassId");

            migrationBuilder.RenameColumn(
                name: "ClientFK",
                table: "Entries",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Entries_PassTypeFK",
                table: "Entries",
                newName: "IX_Entries_PassTypePassId");

            migrationBuilder.RenameIndex(
                name: "IX_Entries_ClientFK",
                table: "Entries",
                newName: "IX_Entries_ClientId");

            migrationBuilder.RenameColumn(
                name: "PassTypeFK",
                table: "ClientPass",
                newName: "PassTypePassId");

            migrationBuilder.RenameColumn(
                name: "ClientFK",
                table: "ClientPass",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientPass_PassTypeFK",
                table: "ClientPass",
                newName: "IX_ClientPass_PassTypePassId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientPass_ClientFK",
                table: "ClientPass",
                newName: "IX_ClientPass_ClientId");

            migrationBuilder.AlterColumn<int>(
                name: "StartTime",
                table: "PassType",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaxDailyUse",
                table: "PassType",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EntriesValidFor",
                table: "PassType",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EndTime",
                table: "PassType",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SalePrice",
                table: "ClientPass",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstUsedOn",
                table: "ClientPass",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PassType_Gym_GymId",
                table: "PassType",
                column: "GymId",
                principalTable: "Gym",
                principalColumn: "GymId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
