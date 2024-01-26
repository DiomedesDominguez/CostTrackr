using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DNMOFT.CostTrackR.Web.Migrations
{
    /// <inheritdoc />
    public partial class NewUserFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "mUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "mUsers",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "mUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "mUsers");
        }
    }
}
