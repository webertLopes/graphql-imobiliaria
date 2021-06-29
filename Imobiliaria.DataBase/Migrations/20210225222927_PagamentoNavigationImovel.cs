using Microsoft.EntityFrameworkCore.Migrations;

namespace Imobiliaria.DataBase.Migrations
{
    public partial class PagamentoNavigationImovel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_Imoveis_ImovelId",
                table: "Pagamentos");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Imoveis",
                newName: "Preco");

            migrationBuilder.AlterColumn<int>(
                name: "ImovelId",
                table: "Pagamentos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_Imoveis_ImovelId",
                table: "Pagamentos",
                column: "ImovelId",
                principalTable: "Imoveis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_Imoveis_ImovelId",
                table: "Pagamentos");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Imoveis",
                newName: "Valor");

            migrationBuilder.AlterColumn<int>(
                name: "ImovelId",
                table: "Pagamentos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_Imoveis_ImovelId",
                table: "Pagamentos",
                column: "ImovelId",
                principalTable: "Imoveis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
