using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academico.Migrations
{
    /// <inheritdoc />
    public partial class imstituicaid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instituição_InstituiçãoOrigemInstituiçãoId",
                table: "Departamentos");

            migrationBuilder.AlterColumn<int>(
                name: "InstituiçãoOrigemInstituiçãoId",
                table: "Departamentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "InstituicaoId",
                table: "Departamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instituição_InstituiçãoOrigemInstituiçãoId",
                table: "Departamentos",
                column: "InstituiçãoOrigemInstituiçãoId",
                principalTable: "Instituição",
                principalColumn: "InstituiçãoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instituição_InstituiçãoOrigemInstituiçãoId",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "InstituicaoId",
                table: "Departamentos");

            migrationBuilder.AlterColumn<int>(
                name: "InstituiçãoOrigemInstituiçãoId",
                table: "Departamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instituição_InstituiçãoOrigemInstituiçãoId",
                table: "Departamentos",
                column: "InstituiçãoOrigemInstituiçãoId",
                principalTable: "Instituição",
                principalColumn: "InstituiçãoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
