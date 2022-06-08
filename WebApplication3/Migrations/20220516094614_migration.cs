using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication3.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationalQualification",
                table: "EducationalQualification");

            migrationBuilder.RenameTable(
                name: "EducationalQualification",
                newName: "EducationalQualifications");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationalQualifications",
                table: "EducationalQualifications",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EducationalForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NameAlt = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    ViewOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalForms", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationalForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationalQualifications",
                table: "EducationalQualifications");

            migrationBuilder.RenameTable(
                name: "EducationalQualifications",
                newName: "EducationalQualification");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationalQualification",
                table: "EducationalQualification",
                column: "Id");
        }
    }
}
