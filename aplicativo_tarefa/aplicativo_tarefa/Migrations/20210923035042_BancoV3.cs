using Microsoft.EntityFrameworkCore.Migrations;

namespace aplicativo_tarefa.Migrations
{
    public partial class BancoV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Proridade",
            //    table: "Tarefas");

            migrationBuilder.AddColumn<string>(
                name: "Prioridade",
                table: "Tarefas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prioridade",
                table: "Tarefas");

            migrationBuilder.AddColumn<string>(
                name: "Proridade",
                table: "Tarefas",
                type: "TEXT",
                nullable: true);
        }
    }
}
