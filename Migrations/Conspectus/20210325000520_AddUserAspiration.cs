using Microsoft.EntityFrameworkCore.Migrations;

namespace Resume.Migrations.Conspectus
{
    public partial class AddUserAspiration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserAspiration",
                table: "Conspectus",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAspiration",
                table: "Conspectus");
        }
    }
}
