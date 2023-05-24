using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPass.DB.Migrations
{
    /// <inheritdoc />
    public partial class HotfixPassTypeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassId",
                table: "PassType",
                newName: "PassTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassTypeId",
                table: "PassType",
                newName: "PassId");
        }
    }
}
