using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPass.DB.Migrations
{
    /// <inheritdoc />
    public partial class ModifyPassTypeTableGym : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PassType_GymId",
                table: "PassType",
                column: "GymId");

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
                name: "FK_PassType_Gym_GymId",
                table: "PassType");

            migrationBuilder.DropIndex(
                name: "IX_PassType_GymId",
                table: "PassType");
        }
    }
}
