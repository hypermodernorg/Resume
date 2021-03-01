using Microsoft.EntityFrameworkCore.Migrations;

namespace Resume.Migrations.Conspectus
{
    public partial class uniqueResumeSlug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Conspectus_ResumeSlug",
                table: "Conspectus",
                column: "ResumeSlug",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Conspectus_ResumeSlug",
                table: "Conspectus");
        }
    }
}
