using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academico.Migrations
{
    /// <inheritdoc />
    public partial class instituiçãodepartamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstituiçãoOrigemInstituiçãoId",
                table: "Departamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_InstituiçãoOrigemInstituiçãoId",
                table: "Departamentos",
                column: "InstituiçãoOrigemInstituiçãoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instituição_InstituiçãoOrigemInstituiçãoId",
                table: "Departamentos",
                column: "InstituiçãoOrigemInstituiçãoId",
                principalTable: "Instituição",
                principalColumn: "InstituiçãoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instituição_InstituiçãoOrigemInstituiçãoId",
                table: "Departamentos");

            migrationBuilder.DropIndex(
                name: "IX_Departamentos_InstituiçãoOrigemInstituiçãoId",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "InstituiçãoOrigemInstituiçãoId",
                table: "Departamentos");
        }
    }
}
