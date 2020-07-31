using Microsoft.EntityFrameworkCore.Migrations;

namespace MinhaAplicacao.Migrations
{
    public partial class MVC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CNPJ",
                table: "Editoras",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "Editoras");
        }
    }
}
