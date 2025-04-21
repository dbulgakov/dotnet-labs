using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab05.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTaskStatusPropertyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemStatus",
                table: "Tasks",
                newName: "Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Tasks",
                newName: "ItemStatus");
        }
    }
}
