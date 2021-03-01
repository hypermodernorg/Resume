using Microsoft.EntityFrameworkCore.Migrations;

namespace Resume.Migrations.Conspectus
{
    public partial class slug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResumeName",
                table: "Conspectus",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumeSlug",
                table: "Conspectus",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResumeSlug",
                table: "Conspectus");

            migrationBuilder.AlterColumn<string>(
                name: "ResumeName",
                table: "Conspectus",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
