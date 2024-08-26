using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BoletoProject.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bancos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeBanco = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    CodigoBanco = table.Column<int>(type: "integer", nullable: false),
                    PercentualJuros = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bancos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boleto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomePagador = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    CpfCnpjPagador = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    NomeBeneficiario = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    CpfCnpjBeneficiario = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false),
                    DataVencimento = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Observacao = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    BancoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boleto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boleto_Bancos_BancoId",
                        column: x => x.BancoId,
                        principalTable: "Bancos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boleto_BancoId",
                table: "Boleto",
                column: "BancoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boleto");

            migrationBuilder.DropTable(
                name: "Bancos");
        }
    }
}
