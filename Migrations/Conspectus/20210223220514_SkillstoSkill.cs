using Microsoft.EntityFrameworkCore.Migrations;

namespace Resume.Migrations.Conspectus
{
    public partial class SkillstoSkill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SkillsName",
                table: "Conspectus",
                newName: "SkillName");

            migrationBuilder.RenameColumn(
                name: "Skills",
                table: "Conspectus",
                newName: "Skill");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SkillName",
                table: "Conspectus",
                newName: "SkillsName");

            migrationBuilder.RenameColumn(
                name: "Skill",
                table: "Conspectus",
                newName: "Skills");
        }
    }
}
