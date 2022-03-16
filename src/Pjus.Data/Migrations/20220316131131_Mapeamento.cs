using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pjus.Data.Migrations
{
    public partial class Mapeamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Cep = table.Column<string>(type: "varchar(10)", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(200)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(250)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(100)", nullable: false),
                    Localidade = table.Column<string>(type: "varchar(100)", nullable: false),
                    UF = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ibge = table.Column<string>(type: "varchar(7)", nullable: false),
                    Gia = table.Column<string>(type: "varchar(4)", nullable: false),
                    DDD = table.Column<string>(type: "varchar(2)", nullable: false),
                    Siafi = table.Column<string>(type: "varchar(4)", nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}
